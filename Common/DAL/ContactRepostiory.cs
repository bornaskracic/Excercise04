using Common.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DAL
{
    public class ContactRepostiory
    {
        private const string PATH = "data.txt";
        public List<Contact> GetAll()
            => File.ReadAllLines(PATH).Select(Contact.FromLine).ToList();

        public void SaveAll(List<Contact> contacts)
            => File.WriteAllLines(PATH,
                   contacts.Select(c => c.ToString()));
    }
}
