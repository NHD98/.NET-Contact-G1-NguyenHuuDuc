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
    public partial class ContactApp : Form
    {
        public ContactApp()
        {
            InitializeComponent();
            List<Contact> list = Contact.getContactList();
            if (list == null)
            {
                throw new Exception("Khong co contact nao");
            }
            else
            {
                bdsContacts.DataSource = list;
                dgvContactList.DataSource = bdsContacts;
            }

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void ContactApp_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search...";
                txtSearch.ForeColor = SystemColors.InactiveCaption;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            List<Contact> list = Contact.getContactByLetter(btnA.Text.ElementAt(0));
            bdsContacts.DataSource = list;
            dgvContactList.DataSource = bdsContacts;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            List<Contact> list = Contact.getContactByLetter(btnD.Text.ElementAt(0));
            bdsContacts.DataSource = list;
            dgvContactList.DataSource = bdsContacts;
        }
        private void btnG_Click(object sender, EventArgs e)
        {
            List<Contact> list = Contact.getContactByLetter(btnG.Text.ElementAt(0));
            bdsContacts.DataSource = list;
            dgvContactList.DataSource = bdsContacts;
        }
        private void btnJ_Click(object sender, EventArgs e)
        {
            List<Contact> list = Contact.getContactByLetter(btnJ.Text.ElementAt(0));
            bdsContacts.DataSource = list;
            dgvContactList.DataSource = bdsContacts;
        }
        private void btnM_Click(object sender, EventArgs e)
        {
            List<Contact> list = Contact.getContactByLetter(btnM.Text.ElementAt(0));
            bdsContacts.DataSource = list;
            dgvContactList.DataSource = bdsContacts;
        }
        private void btnP_Click(object sender, EventArgs e)
        {
            List<Contact> list = Contact.getContactByLetter(btnP.Text.ElementAt(0));
            bdsContacts.DataSource = list;
            dgvContactList.DataSource = bdsContacts;
        }
        private void btnS_Click(object sender, EventArgs e)
        {
            List<Contact> list = Contact.getContactByLetter(btnS.Text.ElementAt(0));
            bdsContacts.DataSource = list;
            dgvContactList.DataSource = bdsContacts;
        }
        private void btnV_Click(object sender, EventArgs e)
        {
            List<Contact> list = Contact.getContactByLetter(btnV.Text.ElementAt(0));
            bdsContacts.DataSource = list;
            dgvContactList.DataSource = bdsContacts;
        }
        private void btnY_Click(object sender, EventArgs e)
        {
            List<Contact> list = Contact.getContactByLetter(btnY.Text.ElementAt(0));
            bdsContacts.DataSource = list;
            dgvContactList.DataSource = bdsContacts;
        }
        private void btnZ_Click(object sender, EventArgs e)
        {
            List<Contact> list = Contact.getContactByLetter(btnZ.Text.ElementAt(0));
            bdsContacts.DataSource = list;
            dgvContactList.DataSource = bdsContacts;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ContactAdd form = new ContactAdd();
            form.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Contact editContact = (Contact)bdsContacts.Current;
            ContactModify form = new ContactModify(editContact);
            form.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //bdsContacts.RemoveCurrent();
            Contact contact = (Contact)bdsContacts.Current;
            bdsContacts.DataSource = Contact.deleteRecord(contact);
            dgvContactList.DataSource = bdsContacts;
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string path = Application.StartupPath + @"/DATA/Contact.txt";
                string[] lines = File.ReadAllLines(path);
                List<Contact> list = Contact.getContactList();
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] temp = lines[i].Split(new char[] { '#' });
                    if (temp[0].Equals(txtSearch.Text) || temp[1].Equals(txtSearch.Text) || temp[2].Equals(txtSearch.Text))
                    {
                        bdsContacts.DataSource = list[i];
                        dgvContactList.DataSource = bdsContacts;
                    }

                }
            }
            if (txtSearch.Text.Equals(""))
            {
                List<Contact> list = Contact.getContactList();
                bdsContacts.DataSource = list;
                dgvContactList.DataSource = bdsContacts;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
