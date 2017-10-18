
using System.Data.Entity.ModelConfiguration;
using OrdemDeServico.Dominio.Entidades;

namespace OrdemDeServico.Infra.Dados.EntidadesConfig
{
    public class ServicoConfiguracao : EntityTypeConfiguration<Servico>
    {
        //-----Criando o construtor ctor
        public ServicoConfiguracao()
        {
            //-----Definindo a chave primaria
            HasKey(s => s.ServicosId);

            //=====Determinando as propriedades
            Property(s => s.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(s => s.Descricao)
                .IsRequired()
                .HasMaxLength(250);

            Property(s => s.Valor)
                .IsRequired();

            Property(s => s.Data)
                .IsRequired();

            //-----Adicionando os relacionamentos - Definindo chave estrangeira
            HasRequired(s => s.Cliente)
                .WithMany()
                .HasForeignKey(s => s.ClienteId);
        }
    }
}
