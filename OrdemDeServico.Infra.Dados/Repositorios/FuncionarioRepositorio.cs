
using System;
using System.Collections.Generic;
using System.Linq;
using OrdemDeServico.Dominio.Entidades;
using OrdemDeServico.Dominio.Interfaces.IRepositorios;

namespace OrdemDeServico.Infra.Dados.Repositorios
{
    public class FuncionarioRepositorio : RepositorioBase<Funcionario>, IFuncionarioRepositorio
    {
        public IEnumerable<Funcionario> BuscarPorNome(string nome)
        {
            return Db.Funcionarios.Where(f => f.Nome == nome);

        }
    }
}
