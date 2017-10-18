
using System.Data.Entity.ModelConfiguration;
using OrdemDeServico.Dominio.Entidades;

namespace OrdemDeServico.Infra.Dados.EntidadesConfig
{
    public class CargoConfiguracao : EntityTypeConfiguration<Cargo>
    {

        //-----Criando o construtor da classe
        public CargoConfiguracao()
        {
            //-----Definindo a chave primaria
            HasKey(c => c.CargoId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
