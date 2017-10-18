
using System;
using System.Collections.Generic;
using System.Linq;
using OrdemDeServico.Dominio.Entidades;
using OrdemDeServico.Dominio.Interfaces.IRepositorios;

namespace OrdemDeServico.Infra.Dados.Repositorios
{
    public class EquipamentoRepositorio : RepositorioBase<Equipamento>, IEquipamentoRepositorio
    {
        public IEnumerable<Equipamento> BuscarPorNome(string nome)
        {
            return Db.Equipamentos.Where(e => e.Nome == nome);
        }
    }
}
