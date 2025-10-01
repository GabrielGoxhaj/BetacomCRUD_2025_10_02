using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDAcademy_10022025.DataModels
{
    public class Hobby
    {

        public string Nome { get; set; }

        [Range(1, 7, ErrorMessage = "Devi inserire un valore compreso tra 1 giorno e 7 giorno")]
        public int FrequenzaSettimanale { get; set; }
        public string Tipologia { get; set; }
        public string Descrizione { get; set; }
        [Range(1901, 2025, ErrorMessage = "Non hai inserito un anno corretto")]
        public int AnnoInizio { get; set; }
    }
}
