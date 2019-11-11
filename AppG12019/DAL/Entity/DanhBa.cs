using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppG12019.DAL.Entity
{
    class DanhBa
    {
        public string tenNhom { get; set; }
        public string tenGoi { get; set; }
        public string email { get; set; }
        public string sdt { get; set; }

        public static List<DanhBa> getDanhBaTheoNhom(string nhom)
        {
            string path = Application.StartupPath + @"/DATA/DanhBa.txt";
            List<DanhBa> list = new List<DanhBa>();
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] temp = lines[i].Split(new char[] { '#' });
                if (temp[0].Equals(nhom))
                {
                    list.Add(new DanhBa
                    {
                        tenGoi = temp[1],
                        email = temp[2],
                        sdt = temp[3],
                        tenNhom = temp[0]
                    });
                }
            }
            return list;
        }

    }
}
