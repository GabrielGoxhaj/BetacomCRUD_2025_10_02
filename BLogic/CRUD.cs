using CRUDAcademy_10022025.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDAcademy_10022025.BLogic;

namespace CRUDAcademy_10022025.BLogic
{
    public class CRUD
    {
        private static List<Studente> studenti = new();
        private static List<Hobby> hobbies = new();
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
            LoadingMenu();
            MenuManager.MainMenu();
        }

        public static async Task MostraStudenti()
        {
            Console.Clear();
            string rowSeparator = new string('-', 100);
            int countStudenti = studenti.Count;
            if (countStudenti == 0)
            {
                NoStudenti();
            }
            else
            {
                Console.WriteLine($"Lista degli {countStudenti} studenti Betacom");
                foreach (var s in studenti)
                {
                    Console.WriteLine($"{s.Nome} {s.Cognome} - {s.Città}, {s.Indirizzo} - Email: {s.Email} - Telefono: {s.Telefono} - Identificativo: {s.Id}");
                }
                Console.WriteLine();
                Console.WriteLine("Premi un tasto qualunque per tornare al menù principale");
                Console.ReadKey();
                LoadingMenu();
                MenuManager.MainMenu();

            }
        }

        public static void EliminaStudente()
        {
            string rowSeparator = new string('-', 100);

            Console.Clear();
            if (studenti.Count == 0)
            {
                NoStudenti();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Quale di questi studenti vuoi eliminare? Inserisci l'identificativo");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var s in studenti)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(rowSeparator);
                    Console.WriteLine($"{s.Nome} {s.Cognome} - {s.Città}, {s.Indirizzo} - Email: {s.Email} - Telefono: {s.Telefono} - Identificativo: {s.Id}");
                    Console.ForegroundColor = ConsoleColor.White;
                    string deletingId = Console.ReadLine();
                    if (deletingId == s.Id)
                    {
                        Console.WriteLine($"Sei sicuro di voler eliminare {s.Nome} {s.Cognome} di {s.Città}?");
                        Console.WriteLine("Premi S se vuoi eliminarlo, altrimenti premi un altro tasto per tornare nel menù principale");
                        string responseDeleteConfirm = Console.ReadLine().ToUpper();
                        if (responseDeleteConfirm == "S")
                        {
                            studenti.Remove(s);
                            Console.WriteLine("Hai cancellato lo studente con successo");
                            LoadingMenu();
                            MenuManager.MainMenu();
                        }
                    }
                }
            }
        }

        public static void AggiornaStudente()
        {
            string rowSeparator = new string('-', 100);
            Console.Clear();
            if (studenti.Count == 0)
            {
                NoStudenti();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Quale di questi studenti vuoi aggiornare? Inserisci l'identificativo");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var s in studenti)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(rowSeparator);
                    Console.WriteLine($"{s.Nome} {s.Cognome} - {s.Città}, {s.Indirizzo} - Email: {s.Email} - Telefono: {s.Telefono} - Identificativo: {s.Id}");
                    Console.ForegroundColor = ConsoleColor.White;
                    string editingId = Console.ReadLine();
                    if (editingId == s.Id)
                    {
                        AggiornaStudenteSelezionato.MenuAggiornaStudente();
                    }
                }
            }
        }

        public static void CreaHobby()
        {
            string rowSeparator = new string('-', 100);
            Console.Clear();
            if (studenti.Count == 0)
            {
                NoStudenti();
            }
            Hobby hobby = new Hobby();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Inserisci il nome dell'hobby:");
            Console.ForegroundColor = ConsoleColor.White;
            hobby.Nome = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Inserisci un numero per indicare la frequenza settimanale (da 1 a 7 giorni alla settimana):");
            Console.ForegroundColor = ConsoleColor.White;
            hobby.FrequenzaSettimanale = Convert.ToInt16(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Inserisci la tipologia di hobby:");
            Console.ForegroundColor = ConsoleColor.White;
            hobby.Tipologia = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Inserisci la descrizione:");
            Console.ForegroundColor = ConsoleColor.White;
            hobby.Descrizione = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Inserisci l'anno d'inizio di frequentazione dell'hobby:");
            Console.ForegroundColor = ConsoleColor.White;
            hobby.AnnoInizio = Convert.ToInt16(Console.ReadLine());
            hobbies.Add(hobby);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(rowSeparator);
            Console.WriteLine($"L'hobby {hobby.Nome} ({hobby.Descrizione}, iniziato nell'anno {hobby.AnnoInizio}) è stato creato con successo");
            Console.ForegroundColor = ConsoleColor.White;
            LoadingMenu();
            MenuManager.MainMenu();
        }
        public static void LoadingMenu()
        {
            string rowSeparator = new string('-', 100);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(rowSeparator);
            Console.WriteLine("Caricando il menù principale...");
            Thread.Sleep(2000); // Waits for 2000 milliseconds (2 seconds)
            Console.WriteLine(rowSeparator);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void NoStudenti()
        {
            string rowSeparator = new string('-', 100);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Non ci sono studenti nell'archivio");
            Console.ForegroundColor = ConsoleColor.White;
            LoadingMenu();
            MenuManager.MainMenu();
        }
    }


}
