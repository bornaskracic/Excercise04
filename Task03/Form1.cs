using Common.DAL;
using Common.DAL.Models;
using System.Collections.ObjectModel;

namespace Task03
{
    public partial class Form1 : Form
    {
        private ContactRepostiory contactRepo = new ContactRepostiory();
        private ObservableCollection<Contact> contacts;
        private FlowLayoutPanel lastSelectedPanel;

        public Form1()
        {
            InitializeComponent();

            ShowMessageOnFail(() =>
            {
                contacts = new (contactRepo.GetAll());
                ShowContacts();
            });

            contacts.CollectionChanged += (sender, e) =>
            {
                contactRepo.SaveAll(contacts.ToList());
                ShowContacts();
            };

        }

        private void ShowContacts()
        {
            flpContainer.Controls.Clear();
            contacts.ToList().ForEach(contact => {
                var panel = ContactViewUtility.CreatePanel(contact);
                panel.Click += (sender, ea) =>
                {
                    if (lastSelectedPanel is not null)
                        lastSelectedPanel.BackColor = SystemColors.Control;
                    panel.BackColor = Color.Aqua;
                    panel.ContextMenuStrip = cmsContactOpts;
                    lastSelectedPanel = panel;
                };
                flpContainer.Controls.Add(panel);
            });
        }

        private void ShowMessageOnFail(Action action)
        {
            try
            {
                action.Invoke();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void optionItem_Click(object sender, EventArgs e)
        {
            if(sender is ToolStripItem item)
            {
                var option = item.Text.ToLower();
                switch (option)
                {
                    case "add":
                        AddContact();
                        break;
                    case "edit":
                        EditContact();
                        break;
                    case "delete":
                        DeleteContact();
                        break;
                }
            }
        }

        private void AddContact()
        {
            var form = new ContactForm();
            if(form.ShowDialog() == DialogResult.OK)
            {
                var contact = form.GetContact();
                contacts.Add(contact);
            }
        }

        private void EditContact()
        {

            var id = new Guid(lastSelectedPanel.Tag.ToString());
            var contact = contacts.First(c => c.Id == id);
            var form = new ContactForm(contact);
            if(form.ShowDialog() == DialogResult.OK)
            {
                var editedContact = form.GetContact();
                contact.Email = editedContact.Email;
                contact.FirstName = editedContact.FirstName;
                contact.LastName = editedContact.LastName;
            }
        }

        private void DeleteContact()
        {
            if (lastSelectedPanel is null)
                return;
            var id = new Guid(lastSelectedPanel.Tag.ToString());
            contacts.Remove(contacts.First(c => c.Id == id));
        }

    }
}