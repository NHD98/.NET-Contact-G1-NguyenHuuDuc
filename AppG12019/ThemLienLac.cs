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
            List<Nhom> list = Nhom.getNhom();
            for (int i = 0; i < list.Count; i++)
            {
                txtNhom.Items.Add(list.ElementAt(i).tenNhom);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"/DATA/DanhBa.txt";
            string tenGoi = txtTenGoi.Text;
            string tenNhom = txtNhom.Text;
            string email = txtEmail.Text;
            string sdt = txtSdt.Text;
            string line = tenNhom + "#" + tenGoi + "#" + email + "#" + sdt + System.Environment.NewLine;
            File.AppendAllText(path, line, Encoding.Unicode);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
