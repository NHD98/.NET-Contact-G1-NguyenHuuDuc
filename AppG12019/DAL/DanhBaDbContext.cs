using AppG12019.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG12019.DAL
{

    public class DanhBaDbContext : DbContext
    {
        public DanhBaDbContext() 
            :base("Data Source=.;Initial Catalog=DanhBa-.Net;Persist Security Info=True;User ID=sa;Password=123")
        {

        }
        public DbSet<DanhBa> DanhBaDbSet { get; set; }
        public DbSet<Nhom> NhomDbSet { get; set; }

    }

}
