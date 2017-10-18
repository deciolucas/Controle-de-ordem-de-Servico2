
using System;
using System.Collections.Generic;
using System.Linq;
using OrdemDeServico.Dominio.Entidades;
using OrdemDeServico.Dominio.Interfaces.IRepositorios;

namespace OrdemDeServico.Infra.Dados.Repositorios
{
    public class CargoRepositorio : RepositorioBase<Cargo>, ICargoRepositorio
    {
        public IEnumerable<Cargo> BuscarPorNome(string nome)
        {            
            return Db.Cargos.Where(c => c.Nome == nome);
        }
    }
}
