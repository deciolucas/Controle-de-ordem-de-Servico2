
using System.Data.Entity.ModelConfiguration;
using OrdemDeServico.Dominio.Entidades;

namespace OrdemDeServico.Infra.Dados.EntidadesConfig
{
    public class ClientesConfiguracao : EntityTypeConfiguration<Cliente>
    {
        //-----Criando o construtor
        public ClientesConfiguracao()
        {
            //-----Informando a chave primaria 
            HasKey(c => c.ClienteId);

            //-----Definindo propiedades 
            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Celular)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
