using AppG12019.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppG12019
{
    public partial class ThemNhom : Form
    {
        public ThemNhom()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // string pathNhom = Application.StartupPath + @"/DATA/Nhom.txt";
            //List<Nhom> list = Nhom.getNhom();
            List<Nhom> list = Nhom.getNhomFromDB();
            string tenNhomMoi = txtTenNhom.Text;
            string maNhomMoi = txtMaNhom.Text;
            bool check = Nhom.themNhomToDB(new Nhom { maNhom = maNhomMoi, tenNhom = tenNhomMoi });
            if (check)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(null, "Không thêm được nhóm", "Error", MessageBoxButtons.OK);
            }
            // bool check = true;
            // for (int i = 0; i < list.Count; i++)
            // {
            //     if (list.ElementAt(i).maNhom.Equals(maNhomMoi) || list.ElementAt(i).tenNhom.Equals(tenNhomMoi))
            //     {
            //          check = false;
            //         break;
            //     }
            //  }
            // if (check)
            //  {
            //      string line = maNhomMoi + "#" + tenNhomMoi + System.Environment.NewLine;
            //      File.AppendAllText(pathNhom, line, Encoding.Unicode);
            //      this.Close();
            //  }
            //  else
            //  {
            //      MessageBox.Show(null, "Nhóm không hợp lệ", "Error", MessageBoxButtons.OK);
            // }
        }
    }
}
