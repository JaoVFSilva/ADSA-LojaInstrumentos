using Loja.Instrumentos.Business;
using Loja.Instrumentos.Generic.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Instrumentos.Data.Entity.TypeConfiguration
{
    class ParticularsTypeConfiguration : LojaEntityAbstractConfig<Particulars>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.Id)
                    .IsRequired()
                    .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                    .HasColumnName("Id");

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Nome");

            Property(p => p.Marca)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("Marca");

            Property(p => p.Descricao)
                .IsOptional()
                .HasMaxLength(2000)
                .HasColumnName("Descricao");

            Property(p => p.Corda)
                .IsRequired()
                .HasColumnName("Corda");

        }

        protected override void ConfigurarChaveEstrangeira()
        {

        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.Id);
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("Particulars");
        }
    }
}
