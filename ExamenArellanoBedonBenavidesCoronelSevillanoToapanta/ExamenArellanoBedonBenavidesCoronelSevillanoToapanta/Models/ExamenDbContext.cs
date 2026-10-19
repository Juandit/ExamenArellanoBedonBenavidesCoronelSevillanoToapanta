using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExamenArellanoBedonBenavidesCoronelSevillanoToapanta.Models
{
    public class ExamenDbContext : DbContext
    {
        public ExamenDbContext() : base("name=ExamenDbContext") { }
    
        public DbSet<Caballero> Caballeros { get; set; }
        public DbSet<Armadura> Armaduras { get; set; }

    }
}