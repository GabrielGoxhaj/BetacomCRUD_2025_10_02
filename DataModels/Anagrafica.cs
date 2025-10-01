using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDAcademy_10022025.DataModels
{
    public class Anagrafica
    {
        [Required]
        public string Nome { get; set; }

        [Key]
        [Required]
        public string Cognome { get; set; }

        [Required]
        public string Città { get; set; }

        [Required]
        public string Indirizzo { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public int Telefono { get; set; }

        public List<Hobby> Hobby { get; set; } = [];
    }
}
