
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using OrdemDeServico.Dominio.Entidades;
using OrdemDeServico.Infra.Dados.EntidadesConfig;

namespace OrdemDeServico.Infra.Dados.Contexto
{
    public class OrdemServicoContexto : DbContext
    {
        //-----Criando um construtor da classe 
        public OrdemServicoContexto()
            :base("ConexaoBdOrdem")
        {

        }
        //-----Criando DbSet para as entidades criadas
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CentroCusto> CentroCustos { get; set; }
        public DbSet<Equipamento> Equipamentos { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<OrdemServico> OrdenServicos { get; set; }
        public DbSet<Peca> Pecas { get; set; }
        public DbSet<Servico> Servicos { get; set; }

        //-----Sobrescrevendo o método onModelCreating
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //-----Desabilitando algumas convencoes do EntityFramework
            //-----Para que nao pluralize os nomes das tabelas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //-----Para nao deletsr rm cascata quando for oneForMany
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //-----Para não deletar em cascata quando for de muitos para muitos
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            //---Outras definiçoes
            //-----Padronizando a chave primaria  das tabelas
            modelBuilder.Properties()
                 .Where(p => p.Name == p.ReflectedType.Name + "Id")
                 .Configure(p => p.IsKey());
            //-----Toda string sera tratada no BD como Varchar
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
            //-----Definindo o tamanho da string
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            //-----Informando ao sitema que é para obedecer a nova configuracao definida
            modelBuilder.Configurations.Add(new CargoConfiguracao());
            modelBuilder.Configurations.Add(new ClientesConfiguracao());
            modelBuilder.Configurations.Add(new CentroCustoConfiguracao());
            modelBuilder.Configurations.Add(new EquipamentoConfiguracao());
            modelBuilder.Configurations.Add(new FornecedorConfiguracao());
            modelBuilder.Configurations.Add(new FuncionarioConfiguracao());
            modelBuilder.Configurations.Add(new OrdemServicoConfiguracao());
            modelBuilder.Configurations.Add(new PecasConfiguracao());
            modelBuilder.Configurations.Add(new ServicoConfiguracao());
        }

        //-----Sobrescrevendo o método para que defina a data do sistema como a data do cadastro
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                //-----Caso seja feitas alteracoes Update, mantenho a data cadastro
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
