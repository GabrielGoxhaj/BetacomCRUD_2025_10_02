using CRUDAcademy_10022025.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDAcademy_10022025.BLogic
{
    public class CRUD
    {
        private static List<Studente> studenti = new();
        public static void CreaStudente()
        {
            string rowSeparator = new string('-', 100);

            Console.Clear();
            Studente studente = new Studente();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Inserisci il nome:");
            Console.ForegroundColor = ConsoleColor.White;
            studente.Nome = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Inserisci il cognome:");
            Console.ForegroundColor = ConsoleColor.White;
            studente.Cognome = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Inserisci la città dove abita:");
            Console.ForegroundColor = ConsoleColor.White;
            studente.Città = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Inserisci l'indirizzo di casa:");
            Console.ForegroundColor = ConsoleColor.White;
            studente.Indirizzo = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Inserisci l'email:");
            Console.ForegroundColor = ConsoleColor.White;
            studente.Email = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Inserisci il numero di telefono:");
            Console.ForegroundColor = ConsoleColor.White;
            studente.Telefono = Convert.ToUInt32(Console.ReadLine());

            string CongomeId = studente.Cognome.Substring(0, 3);
            string NomeId = studente.Nome.Substring(0, 3);

            studente.Id = CongomeId + NomeId;

            studenti.Add(studente);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(rowSeparator);
            Console.WriteLine($"Lo studente {studente.Nome} {studente.Cognome} è stato creato con successo");
            Console.ForegroundColor = ConsoleColor.White;
            MenuManager.MainMenu();
        }

        public static void MostraStudenti()
        {
            Console.Clear();
            int countStudenti = studenti.Count;
            if (countStudenti == 0)
            {
                Console.WriteLine("Non ci sono studenti nell'archivio");
                MenuManager.MainMenu();
            }
            else
            {
                Console.WriteLine($"Lista degli {countStudenti} studenti Betacom");
                foreach (var s in studenti)
                {
                    Console.WriteLine($"{s.Nome} {s.Cognome} - {s.Città}, {s.Indirizzo} - Email: {s.Email} - Telefono: {s.Telefono} - Identificativo: {s.Id}");
                }
                Console.WriteLine();
                MenuManager.MainMenu();
            }

        }

        public static void EliminaStudente()
        {
            string rowSeparator = new string('-', 100);

           
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(rowSeparator);
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Quale di questi studenti vuoi eliminare? Inserisci l'identificativo");
            MostraStudenti();
            string deletingId = Console.ReadLine();
            foreach (var s in studenti)
            {
                if(deletingId == s.Id)
                {
                    Console.WriteLine($"Sei sicuro di voler eliminare {s.Nome} {s.Cognome} di {s.Città}?");
                    Console.WriteLine("Premi S se vuoi eliminarlo, altrimenti premi un altro tasto per tornare nel menù principale");
                    string responseDeleteConfirm = Console.ReadLine().ToUpper();
                    if(responseDeleteConfirm == "S")
                    {
                        studenti.Remove(s);
                        Console.WriteLine("Hai cancellato lo studente con successo");
                        MenuManager.MainMenu();
                    }
                }
            }

        }

        public static void AggiornaPartecipante()
        {

        }

        public static void IdCreator(string nome, string cognome)
        {

        }
    }
}
