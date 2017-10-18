
using System.Data.Entity.ModelConfiguration;
using OrdemDeServico.Dominio.Entidades;

namespace OrdemDeServico.Infra.Dados.EntidadesConfig
{
    public class CentroCustoConfiguracao : EntityTypeConfiguration<CentroCusto>
    {
        //-----Criando o construtor
        public CentroCustoConfiguracao()
        {
            //-----Reafirmando quem é a chave primaria
            HasKey(c => c.CentroCustoId);

            //-----campos obirgatorios
            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Descricao)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
