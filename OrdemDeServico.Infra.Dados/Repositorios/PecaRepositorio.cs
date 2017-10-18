
using System;
using System.Collections.Generic;
using System.Linq;
using OrdemDeServico.Dominio.Entidades;
using OrdemDeServico.Dominio.Interfaces.IRepositorios;

namespace OrdemDeServico.Infra.Dados.Repositorios
{
    public class PecaRepositorio : RepositorioBase<Peca>, IPecaRepositorio
    {
        public IEnumerable<Peca> BuscarPorNome(string nome)
        {
            return Db.Pecas.Where(p => p.Nome == nome);
        }
    }
}
