using AppG12019.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppG12019
{
    public partial class formQuaTrinhHocTapChiTiet : Form
    {
        QuaTrinhHocTap quaTrinhHocTap;
        public formQuaTrinhHocTapChiTiet(QuaTrinhHocTap quaTrinhHocTap = null)
        {
            InitializeComponent();
            this.quaTrinhHocTap = quaTrinhHocTap;
            if (quaTrinhHocTap == null)
            {
                this.Text = "Thêm mới quá trình học tập";
            }
            else
            {
                this.Text = "Chỉnh sửa quá trình học tập";
                numTuNam.Value = quaTrinhHocTap.tuNam;
                numDenNam.Value = quaTrinhHocTap.denNam;
                txtHocTai.Text = quaTrinhHocTap.hocTai;
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (quaTrinhHocTap != null)
            {
                MessageBox.Show("Viet code cap nhat o day");
            } else
            {
                MessageBox.Show("Viet code them moi o day");
            }
            DialogResult = DialogResult.OK;
        }
    }
}
