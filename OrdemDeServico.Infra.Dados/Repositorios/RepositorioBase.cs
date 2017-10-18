
using System;
using System.Collections.Generic;
using OrdemDeServico.Dominio.Interfaces.IRepositorios;
using OrdemDeServico.Infra.Dados.Contexto;
using OrdemDeServico.Dominio.Interfaces;
using System.Data.Entity;
using System.Linq;

namespace OrdemDeServico.Infra.Dados.Repositorios
{
    public class RepositorioBase<TEntity> : IDisposable, IRepositorioBase<TEntity> where TEntity : class
    {
        //-----Criando uma instancia do contexto 
        protected OrdemServicoContexto Db = new OrdemServicoContexto();

        public void Add(TEntity obj)
        {
            //-----Adicionando um objeto generico
            Db.Set<TEntity>().Add(obj);
            //-----Salvando as alteracoes
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            //----Retorna uma lista com todos os objetos poderia usar AsNoTracking
            return Db.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            //-----Retorna uma objeto buscado pelo Id usando o método Find()
            return Db.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            //-----Removendo o objeto do BD
            Db.Set<TEntity>().Remove(obj);
            //-----Salvando as alteracoes no BD
            Db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            //-----A entidade ja existe no BD, foi modificada e para salvar as diferencas
            Db.Entry(obj).State = EntityState.Modified;
            //-----Salvando as alteracoes no BD
            Db.SaveChanges();
        }
    }
}
