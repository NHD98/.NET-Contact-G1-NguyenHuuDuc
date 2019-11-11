using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG12019.DAL.Entity
{
    public class AppG1DBContext : DbContext
    {
        public AppG1DBContext() 
            : base("Data Source=.;Initial Catalog=AppG1;User ID=sa;Password=123")
        {
        }
    public DbSet<SinhVien> SinhVienDbSet { get; set; }
    public DbSet<QuaTrinhHocTap> QuaTrinhHocTapDbSet { get; set; }
}
}
