namespace AppG12019
{
    partial class ContactApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactApp));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvContactList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnA = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.bdsContacts = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(172, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contacts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(248, 86);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(329, 86);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(410, 86);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvContactList);
            this.panel1.Location = new System.Drawing.Point(25, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 298);
            this.panel1.TabIndex = 5;
            // 
            // dgvContactList
            // 
            this.dgvContactList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.colName,
            this.colPhone,
            this.colEmail});
            this.dgvContactList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContactList.Location = new System.Drawing.Point(0, 0);
            this.dgvContactList.Name = "dgvContactList";
            this.dgvContactList.Size = new System.Drawing.Size(416, 298);
            this.dgvContactList.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "firstLetter";
            this.Column1.FillWeight = 101.5228F;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Width = 40;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "name";
            this.colName.FillWeight = 99.49239F;
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // colPhone
            // 
            this.colPhone.DataPropertyName = "phone";
            this.colPhone.FillWeight = 99.49239F;
            this.colPhone.HeaderText = "Phone";
            this.colPhone.Name = "colPhone";
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "email";
            this.colEmail.FillWeight = 99.49239F;
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Lime;
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(401, 419);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 34);
            this.button4.TabIndex = 1;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Location = new System.Drawing.Point(27, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 35);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSearch.Location = new System.Drawing.Point(30, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(427, 23);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Search...";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(447, 115);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(38, 23);
            this.btnA.TabIndex = 17;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(447, 144);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(38, 23);
            this.btnD.TabIndex = 18;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnG
            // 
            this.btnG.Location = new System.Drawing.Point(447, 179);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(38, 23);
            this.btnG.TabIndex = 19;
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // btnJ
            // 
            this.btnJ.Location = new System.Drawing.Point(448, 208);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(37, 25);
            this.btnJ.TabIndex = 20;
            this.btnJ.Text = "J";
            this.btnJ.UseVisualStyleBackColor = true;
            this.btnJ.Click += new System.EventHandler(this.btnJ_Click);
            // 
            // btnM
            // 
            this.btnM.Location = new System.Drawing.Point(448, 239);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(37, 23);
            this.btnM.TabIndex = 21;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnP
            // 
            this.btnP.Location = new System.Drawing.Point(447, 273);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(38, 23);
            this.btnP.TabIndex = 22;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(447, 306);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(38, 23);
            this.btnS.TabIndex = 23;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnV
            // 
            this.btnV.Location = new System.Drawing.Point(448, 335);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(37, 21);
            this.btnV.TabIndex = 24;
            this.btnV.Text = "V";
            this.btnV.UseVisualStyleBackColor = true;
            this.btnV.Click += new System.EventHandler(this.btnV_Click);
            // 
            // btnY
            // 
            this.btnY.Location = new System.Drawing.Point(447, 362);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(38, 23);
            this.btnY.TabIndex = 25;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = true;
            this.btnY.Click += new System.EventHandler(this.btnY_Click);
            // 
            // btnZ
            // 
            this.btnZ.Location = new System.Drawing.Point(447, 391);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(38, 23);
            this.btnZ.TabIndex = 26;
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = true;
            this.btnZ.Click += new System.EventHandler(this.btnZ_Click);
            // 
            // ContactApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 460);
            this.Controls.Add(this.btnZ);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnJ);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Name = "ContactApp";
            this.Text = "Contact";
            this.Click += new System.EventHandler(this.ContactApp_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvContactList;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource bdsContacts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnJ;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnZ;
    }
}