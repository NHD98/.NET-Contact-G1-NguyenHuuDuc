namespace AppG12019
{
    partial class formQuaTrinhHocTapChiTiet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formQuaTrinhHocTapChiTiet));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numTuNam = new System.Windows.Forms.NumericUpDown();
            this.numDenNam = new System.Windows.Forms.NumericUpDown();
            this.txtHocTai = new System.Windows.Forms.TextBox();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTuNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenNam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ năm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến năm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Học tại:";
            // 
            // numTuNam
            // 
            this.numTuNam.Location = new System.Drawing.Point(115, 55);
            this.numTuNam.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numTuNam.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numTuNam.Name = "numTuNam";
            this.numTuNam.Size = new System.Drawing.Size(60, 20);
            this.numTuNam.TabIndex = 3;
            this.numTuNam.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // numDenNam
            // 
            this.numDenNam.Location = new System.Drawing.Point(115, 107);
            this.numDenNam.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numDenNam.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numDenNam.Name = "numDenNam";
            this.numDenNam.Size = new System.Drawing.Size(60, 20);
            this.numDenNam.TabIndex = 4;
            this.numDenNam.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // txtHocTai
            // 
            this.txtHocTai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHocTai.Location = new System.Drawing.Point(115, 155);
            this.txtHocTai.Multiline = true;
            this.txtHocTai.Name = "txtHocTai";
            this.txtHocTai.Size = new System.Drawing.Size(280, 120);
            this.txtHocTai.TabIndex = 5;
            // 
            // btnDongY
            // 
            this.btnDongY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDongY.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDongY.Image = ((System.Drawing.Image)(resources.GetObject("btnDongY.Image")));
            this.btnDongY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDongY.Location = new System.Drawing.Point(224, 301);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(74, 33);
            this.btnDongY.TabIndex = 6;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBoQua.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBoQua.Image = ((System.Drawing.Image)(resources.GetObject("btnBoQua.Image")));
            this.btnBoQua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoQua.Location = new System.Drawing.Point(320, 301);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(75, 33);
            this.btnBoQua.TabIndex = 7;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBoQua.UseVisualStyleBackColor = true;
            // 
            // formQuaTrinhHocTapChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBoQua;
            this.ClientSize = new System.Drawing.Size(448, 346);
            this.ControlBox = false;
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtHocTai);
            this.Controls.Add(this.numDenNam);
            this.Controls.Add(this.numTuNam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formQuaTrinhHocTapChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm/Chỉnh sửa quá trình học tập";
            ((System.ComponentModel.ISupportInitialize)(this.numTuNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenNam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numTuNam;
        private System.Windows.Forms.NumericUpDown numDenNam;
        private System.Windows.Forms.TextBox txtHocTai;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnBoQua;
    }
}