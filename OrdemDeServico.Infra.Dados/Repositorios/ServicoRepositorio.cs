

using System;
using System.Collections.Generic;
using System.Linq;
using OrdemDeServico.Dominio.Entidades;
using OrdemDeServico.Dominio.Interfaces.IRepositorios;

namespace OrdemDeServico.Infra.Dados.Repositorios
{
    public class ServicoRepositorio : RepositorioBase<Servico>, IServicoRepositorio
    {
        public IEnumerable<Servico> BuscarPorNome(string nome)
        {
            return Db.Servicos.Where(s => s.Nome == nome);
        }
    }
}
