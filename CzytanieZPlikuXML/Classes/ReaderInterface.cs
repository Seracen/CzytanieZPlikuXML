using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CzytanieZPlikuXML.Classes
{
    interface ReaderInterface
    {
        /// <summary>
        /// Function retrieving data from xml file or database
        /// </summary>
        /// <returns>Returns list containing strings</returns>
        public List<string> Read();
    }
}
