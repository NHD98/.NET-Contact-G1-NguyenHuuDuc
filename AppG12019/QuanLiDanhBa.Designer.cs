namespace AppG12019
{
    partial class QuanLiDanhBa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLiDanhBa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvNhom = new System.Windows.Forms.DataGridView();
            this.colTenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDanhBa = new System.Windows.Forms.DataGridView();
            this.colTenGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThemNhom = new System.Windows.Forms.ToolStripButton();
            this.btnXoaNhom = new System.Windows.Forms.ToolStripButton();
            this.btnThemLienLac = new System.Windows.Forms.ToolStripButton();
            this.btnXoaLienLac = new System.Windows.Forms.ToolStripButton();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTenGoi = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbSdt = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.bdsNhom = new System.Windows.Forms.BindingSource(this.components);
            this.bdsDanhBa = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhom)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhBa)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDanhBa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvNhom);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 400);
            this.panel1.TabIndex = 0;
            // 
            // dgvNhom
            // 
            this.dgvNhom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenNhom});
            this.dgvNhom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhom.Location = new System.Drawing.Point(0, 0);
            this.dgvNhom.Name = "dgvNhom";
            this.dgvNhom.Size = new System.Drawing.Size(294, 400);
            this.dgvNhom.TabIndex = 0;
            this.dgvNhom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhom_CellClick);
            // 
            // colTenNhom
            // 
            this.colTenNhom.DataPropertyName = "tenNhom";
            this.colTenNhom.HeaderText = "Tên Nhóm";
            this.colTenNhom.Name = "colTenNhom";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDanhBa);
            this.panel2.Location = new System.Drawing.Point(317, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 239);
            this.panel2.TabIndex = 1;
            // 
            // dgvDanhBa
            // 
            this.dgvDanhBa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhBa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhBa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenGoi,
            this.colEmail,
            this.colSDT});
            this.dgvDanhBa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhBa.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhBa.Name = "dgvDanhBa";
            this.dgvDanhBa.Size = new System.Drawing.Size(471, 239);
            this.dgvDanhBa.TabIndex = 0;
            this.dgvDanhBa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhBa_CellClick);
            // 
            // colTenGoi
            // 
            this.colTenGoi.DataPropertyName = "tenGoi";
            this.colTenGoi.HeaderText = "Tên Gọi";
            this.colTenGoi.Name = "colTenGoi";
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            // 
            // colSDT
            // 
            this.colSDT.DataPropertyName = "sdt";
            this.colSDT.HeaderText = "Số điện thoại";
            this.colSDT.Name = "colSDT";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemNhom,
            this.btnXoaNhom,
            this.btnThemLienLac,
            this.btnXoaLienLac,
            this.txtSearch,
            this.toolStripLabel1,
            this.btnRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThemNhom
            // 
            this.btnThemNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNhom.Image")));
            this.btnThemNhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemNhom.Name = "btnThemNhom";
            this.btnThemNhom.Size = new System.Drawing.Size(93, 22);
            this.btnThemNhom.Text = "Thêm nhóm";
            this.btnThemNhom.Click += new System.EventHandler(this.btnThemNhom_Click);
            // 
            // btnXoaNhom
            // 
            this.btnXoaNhom.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNhom.Image")));
            this.btnXoaNhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaNhom.Name = "btnXoaNhom";
            this.btnXoaNhom.Size = new System.Drawing.Size(82, 22);
            this.btnXoaNhom.Text = "Xóa nhóm";
            this.btnXoaNhom.Click += new System.EventHandler(this.btnXoaNhom_Click);
            // 
            // btnThemLienLac
            // 
            this.btnThemLienLac.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLienLac.Image")));
            this.btnThemLienLac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemLienLac.Name = "btnThemLienLac";
            this.btnThemLienLac.Size = new System.Drawing.Size(98, 22);
            this.btnThemLienLac.Text = "Thêm liên lạc";
            this.btnThemLienLac.Click += new System.EventHandler(this.btnThemLienLac_Click);
            // 
            // btnXoaLienLac
            // 
            this.btnXoaLienLac.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaLienLac.Image")));
            this.btnXoaLienLac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaLienLac.Name = "btnXoaLienLac";
            this.btnXoaLienLac.Size = new System.Drawing.Size(87, 22);
            this.btnXoaLienLac.Text = "Xóa liên lạc";
            this.btnXoaLienLac.Click += new System.EventHandler(this.btnXoaLienLac_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 25);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(93, 22);
            this.toolStripLabel1.Text = "Nhập từ cần tìm";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(66, 22);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "[Tên gọi]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(323, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(323, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // lbTenGoi
            // 
            this.lbTenGoi.AutoSize = true;
            this.lbTenGoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenGoi.Location = new System.Drawing.Point(442, 309);
            this.lbTenGoi.Name = "lbTenGoi";
            this.lbTenGoi.Size = new System.Drawing.Size(0, 24);
            this.lbTenGoi.TabIndex = 7;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(442, 339);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(0, 16);
            this.lbDiaChi.TabIndex = 8;
            // 
            // lbSdt
            // 
            this.lbSdt.AutoSize = true;
            this.lbSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSdt.Location = new System.Drawing.Point(442, 376);
            this.lbSdt.Name = "lbSdt";
            this.lbSdt.Size = new System.Drawing.Size(0, 16);
            this.lbSdt.TabIndex = 9;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(442, 409);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(0, 16);
            this.lbEmail.TabIndex = 10;
            // 
            // QuanLiDanhBa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbSdt);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbTenGoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLiDanhBa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLiDanhBa";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhom)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhBa)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDanhBa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvNhom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvDanhBa;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThemNhom;
        private System.Windows.Forms.ToolStripButton btnXoaNhom;
        private System.Windows.Forms.ToolStripButton btnThemLienLac;
        private System.Windows.Forms.ToolStripButton btnXoaLienLac;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bdsNhom;
        private System.Windows.Forms.BindingSource bdsDanhBa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.Label lbTenGoi;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbSdt;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.ToolStripButton btnRefresh;
    }
}