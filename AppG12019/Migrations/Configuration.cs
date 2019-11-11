namespace AppG12019.Migrations
{
    using AppG12019.DAL.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AppG12019.DAL.Entity.AppG1DBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AppG12019.DAL.Entity.AppG1DBContext context)
        {
            context.SinhVienDbSet.AddOrUpdate(new SinhVien
            {
                maSinhVien = "101",
                ho = "Nguyen",
                ten = "B",
                gioiTinh = SEX.Male,
                ngaySinh = new DateTime(2000, 10, 11),
                queQuan = "Hue"
            },
            new SinhVien
            {
                maSinhVien = "102",
                ho = "Tran",
                ten = "C",
                gioiTinh = SEX.Male,
                ngaySinh = new DateTime(2000, 12, 21),
                queQuan = "Hue"
            }
            );

            for (int i = 1; i <= 15; i++)
            {
                context.QuaTrinhHocTapDbSet.AddOrUpdate(new QuaTrinhHocTap
                {
                    maQuaTrinhHocTap = i.ToString(),
                    tuNam = 1996 + i,
                    denNam = 1997 + i,
                    hocTai = "Phan Chu Trinh",
                    maSinhVien = "102",
                });
            }

        }
    }
}
