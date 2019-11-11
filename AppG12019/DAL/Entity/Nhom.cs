using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppG12019.DAL.Entity
{
    class Nhom
    {
        public string maNhom { get; set; }
        public string tenNhom { get; set; }

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
    }
}
