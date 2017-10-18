using System.Data.Entity.ModelConfiguration;
using OrdemDeServico.Dominio.Entidades;

namespace OrdemDeServico.Infra.Dados.EntidadesConfig
{
    public class PecasConfiguracao : EntityTypeConfiguration<Peca>
    {
        //-----criando o construtor
        public PecasConfiguracao()
        {
            //-----Definindo a chave primaria
            HasKey(p => p.PecaId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.Descricao)
               .IsRequired()
               .HasMaxLength(120);

            Property(p => p.Modelo)
               .IsRequired()
               .HasMaxLength(150);
        }
    }
}
