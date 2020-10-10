namespace MSTSolution.LivrosApi.AcessoDados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoTabelaLivros : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Livroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Autor = c.String(),
                        Nr_Paginas = c.Int(nullable: false),
                        Id_Categoria = c.Int(nullable: false),
                        Id_Autor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Livroes");
        }
    }
}
