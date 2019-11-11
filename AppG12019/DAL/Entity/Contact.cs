using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppG12019.DAL.Entity
{
    public class Contact
    {
        //public string id { get; set; }
        public string name { get; set; }
        public char firstLetter { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        public static List<Contact> getContactList()
        {
            string path = Application.StartupPath + @"/DATA/Contact.txt";
            //string path = @"C:\Users\TaiNS\source\repos\AppG12019\AppG12019\DATA\Contact.txt";
            var lines = File.ReadAllLines(path);
            List<Contact> list = new List<Contact>(); ;
            for (int i = 0; i < lines.Length; i++)
            {
                var temp = lines[i].Split(new char[] { '#' });
                list.Add(new Contact
                {
                    firstLetter = temp[0].FirstOrDefault(),
                    name = temp[0],
                    phone = temp[1],
                    email = temp[2]
                });
            }
            return list;
        }

        public static List<Contact> getContactByLetter(char c)
        {
            string path = Application.StartupPath + @"/DATA/Contact.txt";
            //string path = @"C:\Users\TaiNS\source\repos\AppG12019\AppG12019\DATA\Contact.txt";
            var lines = File.ReadAllLines(path);
            List<Contact> list = new List<Contact>();
            for (int i = 0; i < lines.Length; i++)
            {
                var temp = lines[i].Split(new char[] { '#' });
                if (temp[0].FirstOrDefault() >= c)
                    list.Add(new Contact
                    {
                        firstLetter = temp[0].FirstOrDefault(),
                        name = temp[0],
                        phone = temp[1],
                        email = temp[2]
                    });
            }
            return list;
        }

        public static List<Contact> deleteRecord(Contact contact)
        {
            string path = Application.StartupPath + @"/DATA/Contact.txt";
            var lines = File.ReadAllLines(path);
            string[] linesToFile = new string[lines.Length - 1];
            int j = 0;
            List<Contact> list = new List<Contact>();
            for (int i = 0; i < lines.Length; i++)
            {
                var temp = lines[i].Split(new char[] { '#' });
                if (temp[0].Equals(contact.name) == false)
                {
                    linesToFile[j] = lines[i];
                    j++;
                    list.Add(new Contact
                    {
                        firstLetter = temp[0].FirstOrDefault(),
                        name = temp[0],
                        phone = temp[1],
                        email = temp[2]
                    });
                }
            }
            for (int i = 0; i < linesToFile.Length; i++)
            {
                Console.WriteLine(linesToFile[i]);
            }
            File.WriteAllLines(path, linesToFile, Encoding.Unicode);
            return list;
        }
    }
}
