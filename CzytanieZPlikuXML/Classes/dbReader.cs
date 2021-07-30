using CzytanieZPlikuXML.Context;
using CzytanieZPlikuXML.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CzytanieZPlikuXML.Classes
{
    public class dbReader : ReaderInterface
    {
        public dbContext context { get; set; }
        public dbReader() { }
        /// <summary>
        /// Allows to create object with context to a database
        /// </summary>
        /// <param name="context">dbContext allowing connection with database</param>
        public dbReader(dbContext context)
        {
            this.context = context;
        }
        public List<string> Read()
        {
            List<Contact> contactList = context.Contact.ToList();
            List<string> convertedContactList = new List<string>();
            foreach(var contact in contactList)
            {
                convertedContactList.Add(JsonConvert.SerializeObject(contact));
            }
            return convertedContactList;
        }
    }
}
