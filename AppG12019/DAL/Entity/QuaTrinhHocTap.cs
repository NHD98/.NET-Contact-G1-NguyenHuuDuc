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
    public class QuaTrinhHocTap
    {
        [Key]
        public string maQuaTrinhHocTap { get; set; }
        public int tuNam { get; set; }
        public int denNam { get; set; }
        public string thoiGianHoc
        {
            get
            {
                return string.Format("{0} -> {1}", tuNam, denNam);
            }
        }
        public string hocTai { get; set; }
        
        public string maSinhVien { get; set; }
        [ForeignKey("maSinhVien")]
        public virtual SinhVien SinhVien { get; set; }

        /// <summary>
        /// lấy danh sách quá trình học tập của 1 sinh viên
        /// super comment
        /// </summary>
        /// <param name="maSinhVien">Mã sinh viên của sinh viên cần lấy</param>
        /// <returns>Danh sách quá trình học tập</returns>
        public static List<QuaTrinhHocTap> getList(string maSinhVien)
        {
            List<QuaTrinhHocTap> listQuaTrinhHocTap = new List<QuaTrinhHocTap>();
            for (int i = 0; i < 5; i++)
            {
                QuaTrinhHocTap quaTrinhHocTap = new QuaTrinhHocTap
                {
                    maQuaTrinhHocTap = i.ToString(),
                    tuNam = 1990 + i,
                    denNam = 1990 + i + 1,
                    hocTai = "Tam Giang " + i.ToString(),
                    maSinhVien = maSinhVien
                };
                listQuaTrinhHocTap.Add(quaTrinhHocTap);

            }
            return listQuaTrinhHocTap;
        }
        /// <summary>
        /// lấy danh sách quá trình học tập của sinh viên từ file
        /// </summary>
        /// <param name="path">đường dẫn đến file</param>
        /// <param name="maSinhVien">mã sinh viên cần lấy quá trình học tập</param>
        /// <returns></returns>
        public static List<QuaTrinhHocTap> getListFormFile(string path, string maSinhVien)
        {
            List<QuaTrinhHocTap> listQuaTrinhHocTap = new List<QuaTrinhHocTap>();
            var arrayLines = File.ReadAllLines(path);
            foreach (var line in arrayLines)
            {
                if (line.Contains(maSinhVien))
                {
                    var data = line.Split(new char[] { '#' });
                    if (data[0] == maSinhVien)
                    {
                        QuaTrinhHocTap quaTrinhHocTap = new QuaTrinhHocTap
                        {
                            maQuaTrinhHocTap = data[1],
                            tuNam = Convert.ToInt32(data[2]),
                            denNam = Convert.ToInt32(data[3]),
                            hocTai = data[4],
                            maSinhVien = data[0]
                        };
                        listQuaTrinhHocTap.Add(quaTrinhHocTap);
                    }
                }
            }
            return listQuaTrinhHocTap;
        }

        public static void remove(string path, string maQuaTrinhHocTap)
        {
            // code
        }

        public static List<QuaTrinhHocTap> getListFromDB(string maSinhVien)
        {
            return new AppG1DBContext().QuaTrinhHocTapDbSet.
                Where(e => e.maSinhVien == maSinhVien).
                OrderBy(e => e.tuNam).ToList();
        }

    }
}
