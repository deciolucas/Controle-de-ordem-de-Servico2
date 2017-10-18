
using System.Data.Entity.ModelConfiguration;
using OrdemDeServico.Dominio.Entidades;

namespace OrdemDeServico.Infra.Dados.EntidadesConfig
{
    public class FuncionarioConfiguracao : EntityTypeConfiguration<Funcionario>
    {
        //-----Criando o contrutor da classe
        public FuncionarioConfiguracao()
        {
            //-----Chave primaria
            HasKey(f => f.FuncionarioId);

            Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(f => f.Celular)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
