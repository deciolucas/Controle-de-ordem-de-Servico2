
using System.Data.Entity.ModelConfiguration;
using OrdemDeServico.Dominio.Entidades;

namespace OrdemDeServico.Infra.Dados.EntidadesConfig
{
    public class FornecedorConfiguracao : EntityTypeConfiguration<Fornecedor>
    {
        //-----Criando o construtor
        public FornecedorConfiguracao()
        {
            //-----Reafirmando a chave primaria
            HasKey(f => f.FornecedorId);

            Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
