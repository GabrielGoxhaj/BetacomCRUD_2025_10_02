using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDAcademy_10022025.BLogic;


namespace CRUDAcademy_10022025.BLogic
{
    public class AggiornaStudenteSelezionato
    {

        public static void MenuAggiornaStudente()
        {
            string rowSeparator = new string('-', 100);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("===== Menù Modifica Studente =====");
            Console.WriteLine("Cosa vuoi modifica? Inserisci il numero di ciò che vuoi fare");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. Nome");
            Console.WriteLine("2. Cognome");
            Console.WriteLine("3. Città");
            Console.WriteLine("4. Indirizzo");
            Console.WriteLine("5. Email");
            Console.WriteLine("6. Telefono");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("7. Tornare al menù principale");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(rowSeparator);

            Console.ForegroundColor = ConsoleColor.White;

            int scelta = Convert.ToInt16(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    Console.WriteLine("Modifica il nome");
                    MenuManager.MainMenu();
                    break;
                case 2:
                    Console.WriteLine("Modifica il cognome");
                    MenuManager.MainMenu();
                    break;
                case 3:
                    Console.WriteLine("Modifica la città");
                    MenuManager.MainMenu();
                    break;
                case 4:
                    Console.WriteLine("Modifica l'indizzo");
                    MenuManager.MainMenu();
                    break;
                case 5:
                    Console.WriteLine("Modifica la email");
                    MenuManager.MainMenu();
                    break;
                case 6:
                    Console.WriteLine("Modifica il numero di telefono");
                    MenuManager.MainMenu();
                    break;
                case 7:
                    MenuManager.MainMenu();
                    break;
            }
        }
    }
}
