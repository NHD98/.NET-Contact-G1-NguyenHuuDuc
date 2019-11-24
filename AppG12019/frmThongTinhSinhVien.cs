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
    public partial class frmThongTinhSinhVien : Form
    {
        string pathAvatarFolder;
        string pathAvatarImage;
        string pathDataFolder;
        string pathDataText;
        string pathDataLearningHistory;
        int index = -1;

        SinhVien sinhVien;
        public frmThongTinhSinhVien(string maSinhVien)
        {
            InitializeComponent();
            picAvatar.AllowDrop = true;
            pathAvatarFolder = Application.StartupPath + @"\avatar";
            pathAvatarImage = pathAvatarFolder + @"\avatar.jpg";

            pathDataFolder = Application.StartupPath + @"\DATA";
            pathDataText = pathDataFolder + @"\dataStudent.txt";

            pathDataLearningHistory = pathDataFolder + @"\learningHistory.txt";

            if (File.Exists(pathAvatarImage))
            {
                showImageAvatar(pathAvatarImage);
            }

            dgvQuaTrinhHocTap.AutoGenerateColumns = false;


            sinhVien = SinhVien.getFromFile(pathDataText, maSinhVien);
          //  sinhVien = SinhVien.getFromDB(maSinhVien);
            if (sinhVien == null)
            {
                throw new Exception("Sinh viên có mã " + maSinhVien + " không tồn tại");
            }
            else
            {
                txtMaSinhVien.Text = sinhVien.maSinhVien;
                txtHo.Text = sinhVien.ho;
                txtTen.Text = sinhVien.ten;
                dtpNgaySinh.Value = sinhVien.ngaySinh;
                chkNam.Checked = sinhVien.gioiTinh == SEX.Male;
                txtQueQuan.Text = sinhVien.queQuan;

                bdsQuaTrinhHocTap.DataSource = sinhVien.ListQuaTrinhHocTap;
                dgvQuaTrinhHocTap.DataSource = bdsQuaTrinhHocTap;

                lblTongSoMuc.Text = string.Format("{0} mục", sinhVien.ListQuaTrinhHocTap.Count);

            }
        }

        void showImageAvatar(string path, bool saveOption = false)
        {
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            picAvatar.Image = Image.FromStream(fileStream);
            if (saveOption)
            {
                picAvatar.Image.Save(pathAvatarImage);
            }
            fileStream.Close();
        }

        private void LnkChooseAvatar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            #region Chọn ảnh và lưu vào thư mục Avatar
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh đại diện";
            openFileDialog.Filter = "Bạn phải chọn file ảnh (*.png, *.jpg)|*.png;*.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                showImageAvatar(fileName, true);
            }
            #endregion
        }



        private void PicAvatar_DragDrop(object sender, DragEventArgs e)
        {
            try
            {

                var lsFile = (string[])e.Data.GetData(DataFormats.FileDrop);

                showImageAvatar(lsFile.FirstOrDefault(), true);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn file ảnh");
            }
        }

        private void PicAvatar_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void MniXoaAnhDaiDien_Click(object sender, EventArgs e)
        {
            picAvatar.Image = Properties.Resources.avatar;

            if (File.Exists(pathAvatarImage))
                File.Delete(pathAvatarImage);
        }

        private void dgvQuaTrinhHocTap_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvQuaTrinhHocTap.SelectedCells.Count > 0)
            {
                index = dgvQuaTrinhHocTap.SelectedCells[0].RowIndex;
                //Console.WriteLine(index);
            }
            lblTongSoMuc.Text = string.Format("{0} mục", sinhVien.ListQuaTrinhHocTap.Count);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Bạn có thật sự muốn xóa?",
                "Thông báo",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                //xóa dữ liệu
                var quaTrinhHocTap = (QuaTrinhHocTap)bdsQuaTrinhHocTap.Current;

                //xóa quá trình học tập khỏi file
                QuaTrinhHocTap.remove(pathDataLearningHistory, quaTrinhHocTap.maQuaTrinhHocTap);

                //xóa quá trình học tập ra khỏi grid
                //dgvQuaTrinhHocTap.Rows.RemoveAt(index);
                bdsQuaTrinhHocTap.RemoveCurrent();

                /*
                 * MessageBox.Show(
                    "Đã xóa dữ liệu có mã là: " + quaTrinhHocTap.maQuaTrinhHocTap, 
                    "Thông báo", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    */

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            formQuaTrinhHocTapChiTiet form = new formQuaTrinhHocTapChiTiet();
            form.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var quaTrinhHocTap = bdsQuaTrinhHocTap.Current as QuaTrinhHocTap;
            if (quaTrinhHocTap != null)
            {
                formQuaTrinhHocTapChiTiet form = new formQuaTrinhHocTapChiTiet(quaTrinhHocTap);
                form.ShowDialog();
            }
        }
    }
}
