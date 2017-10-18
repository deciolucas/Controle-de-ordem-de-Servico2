
using System;
using System.Collections.Generic;
using System.Linq;
using OrdemDeServico.Dominio.Entidades;
using OrdemDeServico.Dominio.Interfaces.IRepositorios;

namespace OrdemDeServico.Infra.Dados.Repositorios
{
    public class ClienteRepositorio : RepositorioBase<Cliente>, IClienteRepositorio
    {
        public IEnumerable<Cliente> BuscarPorNome(string nome)
        {
            return Db.Clientes.Where(c => c.Nome==nome);
        }
    }
}
