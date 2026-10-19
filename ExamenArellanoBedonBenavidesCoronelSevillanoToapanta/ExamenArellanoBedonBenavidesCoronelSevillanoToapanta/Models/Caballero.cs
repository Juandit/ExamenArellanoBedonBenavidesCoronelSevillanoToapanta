using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExamenArellanoBedonBenavidesCoronelSevillanoToapanta.Models
{
    public class Caballero
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre {  get; set; }
        
        public string Constelacion { get; set; }
        [Range(1,99)]
        public int NivelPoder {  get; set; }
        
        public string Elemento { get; set; }

        public virtual ICollection <Armadura> Armaduras { get; set; }
    }
}