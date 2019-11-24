using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppG12019.DAL.Entity
{
    public class Nhom
    {
        [Key]
        public string maNhom { get; set; }
        public string tenNhom { get; set; }
        public virtual ICollection<DanhBa> danhBa { get; set; }

        public static List<Nhom> getNhom()
        {
            string path = Application.StartupPath + @"/DATA/Nhom.txt";
            List<Nhom> list = new List<Nhom>();
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] temp = lines[i].Split(new char[] { '#' });
                list.Add(new Nhom
                {
                    maNhom = temp[0],
                    tenNhom = temp[1]
                });
            }
            return list;
        }

        public static List<Nhom> getNhomFromDB()
        {
            return new DanhBaDbContext().NhomDbSet.Select(e => e).ToList();
        }

        public static Nhom getNhomByName(string tenNhom)
        {
            string path = Application.StartupPath + @"/DATA/Nhom.txt";
            List<Nhom> list = new List<Nhom>();
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] temp = lines[i].Split(new char[] { '#' });
                list.Add(new Nhom
                {
                    maNhom = temp[0],
                    tenNhom = temp[1]
                });
                if (tenNhom == temp[1])
                    return list.Last();
            }
            return null;
        }

        public static Nhom getNhomFromDBByName(string tenNhom)
        {
            return (Nhom)new DanhBaDbContext().NhomDbSet.Where(e => e.tenNhom == tenNhom).FirstOrDefault();
        }

        public static Nhom getNhomByMaNhom(string maNhom)
        {
            string path = Application.StartupPath + @"/DATA/Nhom.txt";
            List<Nhom> list = new List<Nhom>();
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] temp = lines[i].Split(new char[] { '#' });
                list.Add(new Nhom
                {
                    maNhom = temp[0],
                    tenNhom = temp[1]
                });
                if (maNhom == temp[0])
                    return list.Last();
            }
            return null;
        }

        public static Nhom getNhomFromDBByMaNhom(string maNhom)
        {
            return (Nhom)new DanhBaDbContext().NhomDbSet.Where(e => e.maNhom == maNhom).FirstOrDefault();
        }

        public static bool xoaNhomFromDBByName(string name)
        {
            var db = new DanhBaDbContext();
            var temp = db.NhomDbSet.Where(e => e.tenNhom == name).FirstOrDefault();
            if (temp != null)
            {
                db.NhomDbSet.Remove(temp);
                db.SaveChanges();
                return true;
            }
            else return false;
        }

        public static bool themNhomToDB(Nhom nhom)
        {
            var db = new DanhBaDbContext();
            db.NhomDbSet.Add(nhom);
            db.SaveChanges();
            return true;
        }
    }
}