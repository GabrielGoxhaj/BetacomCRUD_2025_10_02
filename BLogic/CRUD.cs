using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDAcademy_10022025.BLogic
{
    public class CRUD
    {
        public static void CreaPartecipante()
        {
            string rowSeparator = new string('-', 100);
            string nome = "";
            string cognome = "";
            string città = "";
            string indirizzo = "";
            string email = "";
            int telefono;
            int id;

            Console.Clear();
            Console.WriteLine("Inserisci il nome del partecipante");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(rowSeparator);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void MostraPartecipanti()
        {

        }

        public static void EliminaPartecipante()
        {

        }

        public static void AggiornaPartecipante()
        {

        }
    }
}
