namespace AppG12019.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DanhBa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DanhBas",
                c => new
                    {
                        sdt = c.String(nullable: false, maxLength: 128),
                        tenGoi = c.String(),
                        email = c.String(),
                        maNhom = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.sdt)
                .ForeignKey("dbo.Nhoms", t => t.maNhom)
                .Index(t => t.maNhom);
            
            CreateTable(
                "dbo.Nhoms",
                c => new
                    {
                        maNhom = c.String(nullable: false, maxLength: 128),
                        tenNhom = c.String(),
                    })
                .PrimaryKey(t => t.maNhom);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DanhBas", "maNhom", "dbo.Nhoms");
            DropIndex("dbo.DanhBas", new[] { "maNhom" });
            DropTable("dbo.Nhoms");
            DropTable("dbo.DanhBas");
        }
    }
}
