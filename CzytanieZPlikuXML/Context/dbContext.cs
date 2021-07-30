using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CzytanieZPlikuXML.Model;

namespace CzytanieZPlikuXML.Context
{
    public class dbContext : DbContext
    {
        public DbSet<Contact> Contact { get; set; }
        public dbContext(DbContextOptions<dbContext> options) : base(options)
        {

        }
    }
}
