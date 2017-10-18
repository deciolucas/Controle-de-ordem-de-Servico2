
using System;
using System.Collections.Generic;
using System.Linq;
using OrdemDeServico.Dominio.Entidades;
using OrdemDeServico.Dominio.Interfaces.IRepositorios;

namespace OrdemDeServico.Infra.Dados.Repositorios
{
    public class CentroCustoRepositorio : RepositorioBase<CentroCusto>, ICentroCustoRepositorio
    {
        public IEnumerable<CentroCusto> BuscarPorNome(string nome)
        {
            return Db.CentroCustos.Where(c => c.Nome == nome);
        }
    }
}
