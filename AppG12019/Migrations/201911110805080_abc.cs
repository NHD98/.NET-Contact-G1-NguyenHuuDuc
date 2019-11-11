namespace AppG12019.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QuaTrinhHocTaps",
                c => new
                    {
                        maQuaTrinhHocTap = c.String(nullable: false, maxLength: 128),
                        tuNam = c.Int(nullable: false),
                        denNam = c.Int(nullable: false),
                        hocTai = c.String(),
                        maSinhVien = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.maQuaTrinhHocTap)
                .ForeignKey("dbo.SinhViens", t => t.maSinhVien)
                .Index(t => t.maSinhVien);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        maSinhVien = c.String(nullable: false, maxLength: 128),
                        ho = c.String(),
                        ten = c.String(),
                        ngaySinh = c.DateTime(nullable: false),
                        gioiTinh = c.Int(nullable: false),
                        queQuan = c.String(),
                    })
                .PrimaryKey(t => t.maSinhVien);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.QuaTrinhHocTaps", "maSinhVien", "dbo.SinhViens");
            DropIndex("dbo.QuaTrinhHocTaps", new[] { "maSinhVien" });
            DropTable("dbo.SinhViens");
            DropTable("dbo.QuaTrinhHocTaps");
        }
    }
}
