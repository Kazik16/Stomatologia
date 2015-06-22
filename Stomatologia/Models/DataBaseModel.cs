using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Stomatologia.Models
{
    public class DatabaseModel : DbContext
    {
        public DbSet<Lekarz> Lekarze { get; set; }
        public DbSet<Pacjent> Pacjenci { get; set; }
        public DbSet<Wizyta> Wizyty { get; set; }

        public DatabaseModel()
            : base("DefaultConnection")
        {
        }

    }
}