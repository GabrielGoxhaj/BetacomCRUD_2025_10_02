using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDAcademy_10022025.BLogic
{
    public class MenuManager
    {
        public static void MainMenu()
        {
            string rowSeparator = new string('-', 100);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("========= Menù Studenti Betacom =========");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. Aggiungere studente");
            Console.WriteLine("2. Vedere tutti gli studenti");
            Console.WriteLine("3. Aggiornare studente");
            Console.WriteLine("4. Eliminare uno studente");
            Console.WriteLine("5. Creare un hobby per uno degli studenti");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("6. Chiudere il programma");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(rowSeparator);

            Console.ForegroundColor = ConsoleColor.White;

            int scelta = Convert.ToInt16(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    CRUD.CreaStudente();
                    break;
                case 2:
                    CRUD.MostraStudenti();
                    break;
                case 3:
                    CRUD.AggiornaStudente();
                    break;
                case 4:
                    CRUD.EliminaStudente();
                    break;
                case 5:
                    CRUD.CreaHobby();
                    break;
                case 6:
                    Console.WriteLine("Adieau e buon caffè");
                    break;
                default:
                    Console.WriteLine("Non hai inserito un valore corretto");
                    MenuManager.MainMenu();
                    break;
            }
        }

    }
}
