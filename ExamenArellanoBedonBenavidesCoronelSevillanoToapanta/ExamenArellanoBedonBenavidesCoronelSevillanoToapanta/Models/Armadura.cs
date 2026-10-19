using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamenArellanoBedonBenavidesCoronelSevillanoToapanta.Models
{
    public class Armadura
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NombreArmadura { get; set; }

        public string Tipo { get; set; }
        [Range(1, 25)]
        public int Resistencia { get; set; }

        public int CaballeroId { get; set; }

        public virtual ICollection<Caballero> Caballeros { get; set; }
    }
}