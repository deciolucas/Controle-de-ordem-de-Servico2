
using System;
using System.Collections.Generic;
using System.Linq;
using OrdemDeServico.Dominio.Entidades;
using OrdemDeServico.Dominio.Interfaces.IRepositorios;

namespace OrdemDeServico.Infra.Dados.Repositorios
{
    public class FornecedorRepositorio : RepositorioBase<Fornecedor>, IFornecedorRepositorio
    {
        public IEnumerable<Fornecedor> BuscarPorNome(string nome)
        {
            return Db.Fornecedores.Where(f => f.Nome == nome);
        }
    }
}
