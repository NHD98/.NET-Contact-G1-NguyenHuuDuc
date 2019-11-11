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
    public partial class ContactAdd : Form
    {
        public ContactAdd()
        {
            InitializeComponent();
            this.Text = "Thêm mới Danh bạ";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            char firstLetter = name[0];
            Contact contact = new Contact
            {
                name = name,
                phone = phone,
                email = email,
            };
            string line = Environment.NewLine + name + "#" + phone + "#" + email;
            string path = Application.StartupPath + @"/DATA/Contact.txt";
            Console.WriteLine(line);
            File.AppendAllText(path, line, Encoding.Unicode);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
