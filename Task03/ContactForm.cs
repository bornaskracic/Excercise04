using Common.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task03
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        public ContactForm(Contact contact)
        {
            InitializeComponent();
            tbFirstName.Text = contact.FirstName;
            tbLastName.Text = contact.LastName; 
            tbEmail.Text = contact.Email;   
        }

        public Contact GetContact()
            => new Contact(
                    tbFirstName.Text,
                    tbLastName.Text,
                    tbEmail.Text
                );
    }
}
