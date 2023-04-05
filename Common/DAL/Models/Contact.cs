using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DAL.Models
{
    public class Contact
    {
        public Contact(string firstName, string lastName, string email)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public Contact() {}

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public override string ToString()
            => $"{FirstName} {LastName} {Email} {Id}";

        public static Contact FromLine(string line)
        {
            var details = line.Split(' ');
            return new Contact
            {
                FirstName = details[0],
                LastName = details[1],
                Email = details[2],
                Id = new Guid(details[3])
            };
        }
    }
}
