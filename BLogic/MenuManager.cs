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

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Benvenuto nel CRUD dell'Academy .NET n°8 di Betacom!");
            Console.WriteLine("Cosa vuoi fare oggi? Inserisci il numero per l'opzione che più ti garba");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. Aggiungere studente");
            Console.WriteLine("2. Vedere tutti gli studenti");
            Console.WriteLine("3. Aggiornare studente");
            Console.WriteLine("4. Eliminare uno studente");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("5. Chiudere il programma");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(rowSeparator);

            Console.ForegroundColor = ConsoleColor.White;

            int scelta = Convert.ToInt16(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    Console.WriteLine("Hai scelto di aggiungere uno studente");
                    break;
                case 2:
                    Console.WriteLine("Hai scelto di vedere tutti gli studenti salvati");
                    break;
                case 3:
                    Console.WriteLine("Hai scelto di aggiornare uno studente");
                    break;
                case 4:
                    Console.WriteLine("Hai scelto di brasare via uno studente");
                    break;
                case 5:
                    Console.WriteLine("Adieau e buon caffè");
                    break;
            }
        }

    }
}
