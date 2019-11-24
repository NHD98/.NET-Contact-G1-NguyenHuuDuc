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
    public partial class QuanLiDanhBa : Form
    {
        public QuanLiDanhBa()
        {
            InitializeComponent();
            dgvNhom.AutoGenerateColumns = false;
            dgvDanhBa.AutoGenerateColumns = false;
            //List<Nhom> listNhom = Nhom.getNhom();
            List<Nhom> listNhom = Nhom.getNhomFromDB();
            bdsNhom.DataSource = listNhom;
            dgvNhom.DataSource = bdsNhom;
        }

        private void dgvNhom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string tenNhom = (string)dgvNhom.CurrentCell.Value;
            if (tenNhom != null)
            {
                //Nhom nhom = Nhom.getNhomByName(tenNhom);
                Nhom nhom = Nhom.getNhomFromDBByName(tenNhom);
                //List<DanhBa> list = DanhBa.getDanhBaTheoNhom(nhom.maNhom);
                List<DanhBa> list = DanhBa.getDanhBaFromDBTheoNhom(nhom.maNhom);
                bdsDanhBa.DataSource = list;
                dgvDanhBa.DataSource = bdsDanhBa;
            }
        }

        private void dgvDanhBa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string tenGoi = (string)dgvDanhBa.CurrentRow.Cells[0].Value;
            string email = (string)dgvDanhBa.CurrentRow.Cells[1].Value;
            string sdt = (string)dgvDanhBa.CurrentRow.Cells[2].Value;
            lbTenGoi.Text = tenGoi;
            lbSdt.Text = sdt;
            lbEmail.Text = email;
        }

        private void btnThemLienLac_Click(object sender, EventArgs e)
        {
            ThemLienLac form = new ThemLienLac();
            form.Show();
        }
        private void btnXoaLienLac_Click(object sender, EventArgs e)
        {
            string sdt = (string)dgvDanhBa.CurrentRow.Cells[2].Value;
            DanhBa.xoaDanhBaFromDB(sdt);

            refreshList();

            // string tenNhom = (string)dgvNhom.CurrentRow.Cells[0].Value;
            // string tenGoi = (string)dgvDanhBa.CurrentRow.Cells[0].Value;
            // string email = (string)dgvDanhBa.CurrentRow.Cells[1].Value;
            //string sdt = (string)dgvDanhBa.CurrentRow.Cells[2].Value;
            // string path = Application.StartupPath + @"/DATA/DanhBa.txt";
            // string[] lines = File.ReadAllLines(path);
            // File.WriteAllText(path, "");
            // for (int i = 0; i < lines.Length; i++)
            //  {
            //    string[] temp = lines[i].Split(new char[] { '#' });
            //    if (temp[0].Equals(tenNhom) && temp[1].Equals(tenGoi) && temp[2].Equals(email) && temp[3].Equals(sdt))
            //    {
            //   }
            //    else
            //   {
            //        File.AppendAllText(path, lines[i] + System.Environment.NewLine, Encoding.UTF8);
            //    }
            //}
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshList();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string key = txtSearch.Text;
                string tenNhom = (string)dgvNhom.CurrentCell.Value;
                //Nhom nhom = Nhom.getNhomByName(tenNhom);
                Nhom nhom = Nhom.getNhomFromDBByName(tenNhom);
                //List<DanhBa> list = DanhBa.getDanhBaTheoNhom(nhom.maNhom);
                List<DanhBa> list = DanhBa.getDanhBaFromDBTheoNhom(nhom.maNhom);
                List<DanhBa> rs = new List<DanhBa>();
                for (int i = 0; i < list.Count; i++)
                {
                    if (list.ElementAt(i).tenGoi.Equals(key) || list.ElementAt(i).email.Equals(key) || list.ElementAt(i).sdt.Equals(key))
                    {
                        rs.Add(list.ElementAt(i));
                    }
                }
                bdsDanhBa.DataSource = rs;
                dgvDanhBa.DataSource = bdsDanhBa;
            }
            if (txtSearch.Text.Equals(""))
            {
                string tenNhom = (string)dgvNhom.CurrentCell.Value;
                //Nhom nhom = Nhom.getNhomByName(tenNhom);
                Nhom nhom = Nhom.getNhomFromDBByName(tenNhom);
                //List<DanhBa> list = DanhBa.getDanhBaTheoNhom(nhom.maNhom);
                List<DanhBa> list = DanhBa.getDanhBaFromDBTheoNhom(nhom.maNhom);
                bdsDanhBa.DataSource = list;
                dgvDanhBa.DataSource = bdsDanhBa;
            }
        }

        private void btnThemNhom_Click(object sender, EventArgs e)
        {
            ThemNhom form = new ThemNhom();
            form.Show();
        }

        private void btnXoaNhom_Click(object sender, EventArgs e)
        {
            string tenNhomXoa = (string)dgvNhom.CurrentCell.Value;

            var nhom = Nhom.getNhomFromDBByName(tenNhomXoa);
            DanhBa.xoaDanhBaByNhom(nhom.maNhom);
            Nhom.xoaNhomFromDBByName(tenNhomXoa);
            refreshList();
            //string pathNhom = Application.StartupPath + @"/DATA/Nhom.txt";
            //string pathDanhBa = Application.StartupPath + @"/DATA/DanhBa.txt";

            //string[] linesNhom = File.ReadAllLines(pathNhom);
            //string[] linesDanhBa = File.ReadAllLines(pathDanhBa);

            //File.WriteAllText(pathNhom, "");
            //File.WriteAllText(pathDanhBa, "");

            //string newline = System.Environment.NewLine;
            //for (int i = 0; i < linesNhom.Length; i++)
            //{
            //    string[] temp = linesNhom[i].Split(new char[] { '#' });
            //    if (!temp[1].Equals(tenNhomXoa))
            //    {
            //       File.AppendAllText(pathNhom, linesNhom[i] + newline, Encoding.Unicode);
            //   }
            //}

            //for (int i = 0; i < linesDanhBa.Length; i++)
            //// {
            //    string[] temp = linesDanhBa[i].Split(new char[] { '#' });
            //    if (!temp[0].Equals(tenNhomXoa))
            //    {
            //         File.AppendAllText(pathDanhBa, linesDanhBa[i] + newline, Encoding.Unicode);
            //     }
            // }

        }

        public void refreshList()
        {
            //List<Nhom> listNhom = Nhom.getNhom();
            List<Nhom> listNhom = Nhom.getNhomFromDB();
            bdsNhom.DataSource = listNhom;
            dgvNhom.DataSource = bdsNhom;
            if (listNhom.Count > 0)
            {
                string tenNhom = (string)dgvNhom.CurrentCell.Value;
                //Nhom nhom = Nhom.getNhomByName(tenNhom);
                Nhom nhom = Nhom.getNhomFromDBByName(tenNhom);
                //List<DanhBa> list = DanhBa.getDanhBaTheoNhom(nhom.maNhom);
                List<DanhBa> list = DanhBa.getDanhBaFromDBTheoNhom(nhom.maNhom);
                bdsDanhBa.DataSource = list;
                dgvDanhBa.DataSource = bdsDanhBa;
            }
        }
    }
}
