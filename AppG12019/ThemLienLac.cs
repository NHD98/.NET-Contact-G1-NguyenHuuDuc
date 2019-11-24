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
    public partial class ThemLienLac : Form
    {
        public ThemLienLac()
        {
            InitializeComponent();
            //List<Nhom> list = Nhom.getNhom();
            List<Nhom> list = Nhom.getNhomFromDB();
            for (int i = 0; i < list.Count; i++)
            {
                txtNhom.Items.Add(list.ElementAt(i).tenNhom);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //string path = Application.StartupPath + @"/DATA/DanhBa.txt";
            string tenGoi = txtTenGoi.Text;
            string tenNhom = txtNhom.Text;
            string email = txtEmail.Text;
            string sdt = txtSdt.Text;
            // string line = tenNhom + "#" + tenGoi + "#" + email + "#" + sdt + System.Environment.NewLine;
            //File.AppendAllText(path, line, Encoding.Unicode);
            Nhom temp0 = Nhom.getNhomFromDBByName(tenNhom);
            DanhBa temp = new DanhBa { tenGoi = tenGoi, maNhom = temp0.maNhom, email = email, sdt = sdt };
            bool check = DanhBa.themDanhBaToDB(temp);
            if (check)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(null, "Không thêm được nhóm", "Error", MessageBoxButtons.OK);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
