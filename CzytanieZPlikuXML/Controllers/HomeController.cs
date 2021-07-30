using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using System.Text;
using CzytanieZPlikuXML.Classes;
using CzytanieZPlikuXML.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CzytanieZPlikuXML.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyConfiguration myConfiguration;
        private readonly dbContext context;
        public HomeController(IOptions<MyConfiguration> config, IConfiguration configuration)
        {
            myConfiguration = config.Value;
            var optionBuilder = new DbContextOptionsBuilder<dbContext>();
            optionBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString"));
            context = new dbContext(optionBuilder.Options);
        }
        /// <summary>
        /// Function that retrieve contact data from xml file or database
        /// </summary>
        /// <returns>IEnumerable containing strings</returns>
        public IEnumerable<string> GetContacts()
        {
            string confType = myConfiguration.ConnectionType;
            List<string> dataToReturn = null;
            switch (confType)
            {
                case "xml":
                    {
                        string fileName = myConfiguration.FileName;
                        XMLReader xmlReader = new XMLReader(fileName);
                        dataToReturn = xmlReader.Read();
                        break;
                    }
                case "database":
                    {
                        dbReader reader = new dbReader(context);
                        dataToReturn = reader.Read();
                        break;
                    }
            }
            return dataToReturn;
        }

    }
}
