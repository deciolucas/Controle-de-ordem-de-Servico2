
using System.Data.Entity.ModelConfiguration;
using OrdemDeServico.Dominio.Entidades;

namespace OrdemDeServico.Infra.Dados.EntidadesConfig
{
    public class EquipamentoConfiguracao : EntityTypeConfiguration<Equipamento>
    {
        //-----Criando o contrutor
        public EquipamentoConfiguracao()
        {
            //-----Definindo a chave primaria
            HasKey(e => e.EquipamentoId);

            Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(e => e.Descricao)
                .IsRequired()
                .HasMaxLength(150);
            //-----Definindo chave estrangeira
            HasRequired(s => s.Fornecedor)
                .WithMany()
                .HasForeignKey(s => s.FornecedorId);
        }
    }
}
