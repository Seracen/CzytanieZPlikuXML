using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CzytanieZPlikuXML.Model
{
    /// <summary>
    /// Model class representing Contacts
    /// </summary>
    public class Contact
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        [Key]
        public string Telefon { get; set; }
        public string Email { get; set; }

        public Contact() { }
        /// <param name="name">person's name</param>
        /// <param name="surName">person's surname</param>
        /// <param name="phoneNumber">person's phone number</param>
        /// <param name="email">person's email</param>
        public Contact(string name, string surName, string phoneNumber, string email)
        {
            this.Imie = name;
            this.Nazwisko = surName;
            this.Telefon = phoneNumber;
            this.Email = email;
        }
    }
}
