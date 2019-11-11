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
    public partial class ContactModify : Form
    {
        public ContactModify(Contact contact)
        {
            InitializeComponent();
            this.Text = "Modify Contact";
            txtEmail.Text = contact.email;
            txtPhone.Text = contact.phone;
            txtName.Text = contact.name;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"/DATA/Contact.txt";
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] temp = lines[i].Split(new char[] { '#' });
                string name = txtName.Text;
                string phone = txtPhone.Text;
                string email = txtEmail.Text;
                if (temp[1].Equals(phone) || temp[2].Equals(email))
                {
                    lines[i] = name + "#" + phone + "#" + email;
                    break;
                }
            }
            File.WriteAllLines(path, lines, Encoding.Unicode);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
