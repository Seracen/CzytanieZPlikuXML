using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using Newtonsoft.Json;
using System.Threading.Tasks;
using CzytanieZPlikuXML.Classes;

namespace CzytanieZPlikuXML.Classes
{
    public class XMLReader : ReaderInterface
    {
        public string fileName { get; set; }
        public XMLReader() { }
        /// <summary>
        /// Allows to create object with given file name
        /// </summary>
        /// <param name="fileName">Name of a file</param>
        public XMLReader(string fileName)
        {
            this.fileName = fileName;
        }
        public List<string> Read()
        {
            string tKey = "";
            List<string> convertedDictionary = null;
            Dictionary<string, string> contactDictionary = null;
            using (XmlReader xmlReader = XmlReader.Create(fileName))
            {
                while (xmlReader.Read())
                {
                    if (xmlReader.NodeType == XmlNodeType.Element && xmlReader.Name == "Kontakt")
                    {
                        if (convertedDictionary == null)
                        {
                            contactDictionary = new Dictionary<string, string>();
                            convertedDictionary = new List<string>();
                        }
                    }
                    else if (xmlReader.NodeType == XmlNodeType.Element)
                    {
                        tKey = xmlReader.Name;
                    }
                    else if (xmlReader.NodeType == XmlNodeType.Text)
                    {
                        if (!contactDictionary.ContainsKey(tKey))
                            contactDictionary.Add(tKey, xmlReader.Value);
                        else
                            contactDictionary[tKey] = xmlReader.Value;
                    }
                    else if (xmlReader.NodeType == XmlNodeType.EndElement && xmlReader.Name == "Kontakt")
                    {
                        convertedDictionary.Add(JsonConvert.SerializeObject(contactDictionary));
                    }
                }
            }
            return convertedDictionary;
        }
    }
}
