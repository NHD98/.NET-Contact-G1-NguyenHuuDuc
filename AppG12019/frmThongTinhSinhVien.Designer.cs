namespace AppG12019
{
    partial class frmThongTinhSinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinhSinhVien));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaSinhVien = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.chkNam = new System.Windows.Forms.CheckBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.lnkChooseAvatar = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvQuaTrinhHocTap = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTongSoMuc = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.ctmPictureAvatar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mniXoaAnhDaiDien = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.bdsQuaTrinhHocTap = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuaTrinhHocTap)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.ctmPictureAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsQuaTrinhHocTap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sinh viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giới tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Quê quán:";
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaSinhVien.Location = new System.Drawing.Point(225, 12);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Size = new System.Drawing.Size(221, 20);
            this.txtMaSinhVien.TabIndex = 0;
            // 
            // txtHo
            // 
            this.txtHo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHo.Location = new System.Drawing.Point(225, 38);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(136, 20);
            this.txtHo.TabIndex = 1;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(225, 65);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(117, 20);
            this.dtpNgaySinh.TabIndex = 2;
            // 
            // chkNam
            // 
            this.chkNam.AutoSize = true;
            this.chkNam.Location = new System.Drawing.Point(225, 92);
            this.chkNam.Name = "chkNam";
            this.chkNam.Size = new System.Drawing.Size(48, 17);
            this.chkNam.TabIndex = 3;
            this.chkNam.Text = "Nam";
            this.chkNam.UseVisualStyleBackColor = true;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQueQuan.Location = new System.Drawing.Point(225, 115);
            this.txtQueQuan.Multiline = true;
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(221, 50);
            this.txtQueQuan.TabIndex = 4;
            // 
            // lnkChooseAvatar
            // 
            this.lnkChooseAvatar.AutoSize = true;
            this.lnkChooseAvatar.Location = new System.Drawing.Point(28, 131);
            this.lnkChooseAvatar.Name = "lnkChooseAvatar";
            this.lnkChooseAvatar.Size = new System.Drawing.Size(94, 13);
            this.lnkChooseAvatar.TabIndex = 5;
            this.lnkChooseAvatar.TabStop = true;
            this.lnkChooseAvatar.Text = "Chọn ảnh đại diện";
            this.lnkChooseAvatar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkChooseAvatar_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvQuaTrinhHocTap);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(18, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 222);
            this.panel1.TabIndex = 6;
            // 
            // dgvQuaTrinhHocTap
            // 
            this.dgvQuaTrinhHocTap.AllowUserToAddRows = false;
            this.dgvQuaTrinhHocTap.AllowUserToDeleteRows = false;
            this.dgvQuaTrinhHocTap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuaTrinhHocTap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4});
            this.dgvQuaTrinhHocTap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuaTrinhHocTap.Location = new System.Drawing.Point(0, 25);
            this.dgvQuaTrinhHocTap.Name = "dgvQuaTrinhHocTap";
            this.dgvQuaTrinhHocTap.ReadOnly = true;
            this.dgvQuaTrinhHocTap.Size = new System.Drawing.Size(427, 173);
            this.dgvQuaTrinhHocTap.TabIndex = 0;
            this.dgvQuaTrinhHocTap.SelectionChanged += new System.EventHandler(this.dgvQuaTrinhHocTap_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maQuaTrinhHocTap";
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "thoiGianHoc";
            this.Column2.HeaderText = "Thời gian học";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "hocTai";
            this.Column4.HeaderText = "Học tại";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTongSoMuc});
            this.statusStrip1.Location = new System.Drawing.Point(0, 198);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(427, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTongSoMuc
            // 
            this.lblTongSoMuc.Name = "lblTongSoMuc";
            this.lblTongSoMuc.Size = new System.Drawing.Size(116, 17);
            this.lblTongSoMuc.Text = "Tổng số mục: 0 mục";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnXoa,
            this.btnSua,
            this.btnThem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(427, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(100, 22);
            this.toolStripLabel1.Text = "Quá trình học tập";
            // 
            // btnXoa
            // 
            this.btnXoa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnXoa.Image = global::AppG12019.Properties.Resources.delete;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(47, 22);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSua.Image = global::AppG12019.Properties.Resources.edit;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(46, 22);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnThem.Image = global::AppG12019.Properties.Resources.plus;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(58, 22);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Image = global::AppG12019.Properties.Resources.refresh;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(280, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cập nhật";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::AppG12019.Properties.Resources.back_arrow;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(372, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Bỏ qua";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // picAvatar
            // 
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.ContextMenuStrip = this.ctmPictureAvatar;
            this.picAvatar.Image = global::AppG12019.Properties.Resources.avatar;
            this.picAvatar.Location = new System.Drawing.Point(19, 12);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(113, 116);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            this.picAvatar.DragDrop += new System.Windows.Forms.DragEventHandler(this.PicAvatar_DragDrop);
            this.picAvatar.DragEnter += new System.Windows.Forms.DragEventHandler(this.PicAvatar_DragEnter);
            // 
            // ctmPictureAvatar
            // 
            this.ctmPictureAvatar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniXoaAnhDaiDien});
            this.ctmPictureAvatar.Name = "ctmPictureAvatar";
            this.ctmPictureAvatar.Size = new System.Drawing.Size(163, 26);
            // 
            // mniXoaAnhDaiDien
            // 
            this.mniXoaAnhDaiDien.Image = global::AppG12019.Properties.Resources.delete;
            this.mniXoaAnhDaiDien.Name = "mniXoaAnhDaiDien";
            this.mniXoaAnhDaiDien.Size = new System.Drawing.Size(162, 22);
            this.mniXoaAnhDaiDien.Text = "Xóa ảnh đại diện";
            this.mniXoaAnhDaiDien.Click += new System.EventHandler(this.MniXoaAnhDaiDien_Click);
            // 
            // txtTen
            // 
            this.txtTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTen.Location = new System.Drawing.Point(367, 38);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(79, 20);
            this.txtTen.TabIndex = 7;
            // 
            // frmThongTinhSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 471);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lnkChooseAvatar);
            this.Controls.Add(this.chkNam);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.txtMaSinhVien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picAvatar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThongTinhSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin sinh viên";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuaTrinhHocTap)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ctmPictureAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsQuaTrinhHocTap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaSinhVien;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.CheckBox chkNam;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.LinkLabel lnkChooseAvatar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvQuaTrinhHocTap;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTongSoMuc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip ctmPictureAvatar;
        private System.Windows.Forms.ToolStripMenuItem mniXoaAnhDaiDien;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.BindingSource bdsQuaTrinhHocTap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}