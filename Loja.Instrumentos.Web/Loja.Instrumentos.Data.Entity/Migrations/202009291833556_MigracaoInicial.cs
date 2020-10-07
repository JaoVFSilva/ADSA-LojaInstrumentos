namespace Loja.Instrumentos.Data.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigracaoInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Particulars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Marca = c.String(nullable: false, maxLength: 50),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Corda = c.Int(nullable: false),
                        Descricao = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Particulars");
        }
    }
}
