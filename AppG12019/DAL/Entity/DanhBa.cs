using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppG12019.DAL.Entity
{
    public class DanhBa
    {
        [Key]
        public string sdt { get; set; }
        public string tenGoi { get; set; }
        public string email { get; set; }
        public string maNhom { get; set; }
        [ForeignKey("maNhom")]
        public virtual Nhom nhom { get; set; }

        public static List<DanhBa> getDanhBaTheoNhom(string maNhom)
        {
            string path = Application.StartupPath + @"/DATA/DanhBa.txt";
            List<DanhBa> list = new List<DanhBa>();
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] temp = lines[i].Split(new char[] { '#' });
                if (temp[0].Equals(maNhom))
                {
                    list.Add(new DanhBa
                    {
                        tenGoi = temp[1],
                        email = temp[2],
                        sdt = temp[3],
                        nhom = Nhom.getNhomByMaNhom(temp[0])
                    });
                }
            }
            return list;
        }

        public static List<DanhBa> getDanhBaFromDBTheoNhom(string maNhom)
        {
            return new DanhBaDbContext().DanhBaDbSet.Where(e => e.maNhom == maNhom).ToList();
        }

        public static DanhBa getDanhBaFromDBBySDT(string sdt)
        {
            return (DanhBa)new DanhBaDbContext().DanhBaDbSet.Where(e => e.sdt == sdt).FirstOrDefault();
        }

        public static bool xoaDanhBaFromDB(string sdt)
        {
            var db = new DanhBaDbContext();
            var temp = db.DanhBaDbSet.Where(e => e.sdt == sdt).FirstOrDefault();
            db.DanhBaDbSet.Remove(temp);
            db.SaveChanges();
            return true;
        }

        public static bool themDanhBaToDB(DanhBa danhBa)
        {
            var db = new DanhBaDbContext();
            db.DanhBaDbSet.Add(danhBa);
            db.SaveChanges();
            return true;
        }

        public static bool xoaDanhBaByNhom(string maNhom)
        {
            var db = new DanhBaDbContext();
            List<DanhBa> list = db.DanhBaDbSet.Where(e => e.maNhom == maNhom).ToList();
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    db.DanhBaDbSet.Remove(list.ElementAt(i));
                }
                db.SaveChanges();
                return true;
            }
            else return false;
        }
    }
}
