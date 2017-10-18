using System.Data.Entity.ModelConfiguration;
using OrdemDeServico.Dominio.Entidades;

namespace OrdemDeServico.Infra.Dados.EntidadesConfig
{
    public class OrdemServicoConfiguracao : EntityTypeConfiguration<OrdemServico>
    {
        //-----Criando o construtor ctor
        public OrdemServicoConfiguracao()
        {
            //-----Reafirmando a chave primaria
            HasKey(o => o.OrdemServicoId);

            Property(o => o.ClienteId)
                .IsRequired();

            Property(o => o.ServicoId)
                .IsRequired();

            //-----Adicionando os relacionamentos - Definindo chave estrangeira
            //-----Cliente
            HasRequired(s => s.Cliente)
                .WithMany()
                .HasForeignKey(s => s.ClienteId);
            //-----Serviço
            HasRequired(s => s.Servico)
                .WithMany()
                .HasForeignKey(s => s.ServicoId);
            //-----Funcionario
            HasRequired(s => s.Funcionario)
                .WithMany()
                .HasForeignKey(s => s.FuncionarioId);
            //-----Equipamento
            HasRequired(s => s.Equipamento)
                .WithMany()
                .HasForeignKey(s => s.EquipamentoId);
        }
    }
}