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
        public static List<Studente> studenti = new();
        public static List<Hobby> hobbies = new();
        public static void CreaStudente()
        {
            string rowSeparator = new string('-', 100);

            Console.Clear();
            Studente studente = new Studente();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("========= Menù Creazione Studenti Betacom =========");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Inserisci il nome: ");
            Console.ForegroundColor = ConsoleColor.White;
            studente.Nome = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Inserisci il cognome: ");
            Console.ForegroundColor = ConsoleColor.White;
            studente.Cognome = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Inserisci la città dove abita: ");
            Console.ForegroundColor = ConsoleColor.White;
            studente.Città = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Inserisci l'indirizzo di casa: ");
            Console.ForegroundColor = ConsoleColor.White;
            studente.Indirizzo = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Inserisci l'email: ");
            Console.ForegroundColor = ConsoleColor.White;
            studente.Email = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Inserisci il numero di telefono: ");
            Console.ForegroundColor = ConsoleColor.White;
            studente.Telefono = Convert.ToUInt32(Console.ReadLine());
            string CongomeId = studente.Cognome.Substring(0, 3);
            string NomeId = studente.Nome.Substring(0, 3);
            studente.Id = CongomeId + NomeId;
            studenti.Add(studente);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(rowSeparator);
            Console.WriteLine($"Lo studente {studente.Nome} {studente.Cognome} è stato creato con successo");
            Console.WriteLine(rowSeparator);
            Console.ForegroundColor = ConsoleColor.White;
            LoadingMenu();
            MenuManager.MainMenu();
        }

        public static void MostraStudenti()
        {
            Console.Clear();
            string rowSeparator = new string('-', 150);
            int countStudenti = studenti.Count;
            if (countStudenti == 0)
            {
                NoStudenti();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(rowSeparator);
                Console.WriteLine($"Lista degli studenti di Betacom");
                Console.WriteLine(rowSeparator);
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var s in studenti)
                {
                    Console.WriteLine($"{s.Nome} {s.Cognome} - {s.Città}, {s.Indirizzo} - Email: {s.Email} - Telefono: {s.Telefono} - Identificativo: {s.Id}");
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(rowSeparator);
                Console.ForegroundColor = ConsoleColor.White;
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
                Console.WriteLine("Quale di questi studenti vuoi eliminare?");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var s in studenti)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(rowSeparator);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{s.Nome} {s.Cognome} - {s.Città}, {s.Indirizzo} - Email: {s.Email} - Telefono: {s.Telefono} - Identificativo: {s.Id}");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(rowSeparator);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Inserisci l'identificativo: ");
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
                Console.WriteLine("Quale di questi studenti vuoi aggiornare?");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(rowSeparator);
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var s in studenti)
                {
                    Console.WriteLine($"{s.Nome} {s.Cognome} - {s.Città}, {s.Indirizzo} - Email: {s.Email} - Telefono: {s.Telefono} - Identificativo: {s.Id}");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(rowSeparator);
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.Write("Inserisci l'identificativo dello studente:");
                string editingId = Console.ReadLine();
                var studente = studenti.FirstOrDefault(x => x.Id == editingId);
                if (editingId == "null")
                {
                    Console.WriteLine("Lo studente non è stato trovato!");
                    Loading();
                    AggiornaStudente();
                    return;
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("===== Menù Modifica Studente =====");
                Console.WriteLine("Cosa vuoi modificare? Inserisci il numero di ciò che vuoi fare");
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
                string risposta = "";

                switch (scelta)
                {
                    case 1:
                        Console.WriteLine($"Inserisci un nuovo nome per {studente.Nome} {studente.Cognome}");
                        studente.Nome = Console.ReadLine();
                        Console.WriteLine($"Hai cambiato il nome in {studente.Nome} correttamente");
                        Loading();
                        AggiornaStudente();
                        break;
                    case 2:
                        Console.WriteLine($"Inserisci un nuovo cognome per {studente.Nome} {studente.Cognome}");
                        studente.Cognome = Console.ReadLine();
                        Console.WriteLine($"Hai cambiato il nome in {studente.Cognome} correttamente");
                        Loading();
                        AggiornaStudente();
                        break;
                    case 3:
                        Console.WriteLine($"Modifica la città di provenienza di {studente.Nome} {studente.Cognome}");
                        studente.Città = Console.ReadLine();
                        Console.WriteLine($"Hai cambiato la città di provenienza in {studente.Città} correttamente");
                        Loading();
                        AggiornaStudente();
                        break;
                    case 4:
                        Console.WriteLine($"Inserisci un nuovo indirizzo di residenza per {studente.Nome} {studente.Cognome}");
                        studente.Indirizzo = Console.ReadLine();
                        Console.WriteLine($"Hai cambiato l'indirizzo di residenza in: {studente.Indirizzo} correttamente");
                        Loading();
                        AggiornaStudente();
                        break;
                    case 5:
                        Console.WriteLine($"Inserisci una nuova email per {studente.Nome} {studente.Cognome}");
                        studente.Email = Console.ReadLine();
                        Console.WriteLine($"Hai cambiato l'email in: {studente.Email} correttamente");
                        Loading();
                        AggiornaStudente();
                        break;
                    case 6:
                        Console.WriteLine($"Inserisci un nuovo numero di telefono per {studente.Nome} {studente.Cognome}");
                        studente.Telefono = Convert.ToUInt32(Console.ReadLine());
                        Console.WriteLine($"Hai cambiato l'indirizzo di residenza in: {studente.Telefono} correttamente");
                        Loading();
                        AggiornaStudente();
                        break;
                    case 7:
                        LoadingMenu();
                        break;
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
            Thread.Sleep(200);
            Console.ForegroundColor = ConsoleColor.White;
            LoadingMenu();
            MenuManager.MainMenu();
        }

        public static void Loading()
        {
            string rowSeparator = new string('-', 100);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Caricando, attendere prego.");
            Thread.Sleep(500);
            Console.Clear();
            Console.Write("Caricando, attendere prego..");
            Thread.Sleep(500);
            Console.Clear();
            Console.Write("Caricando, attendere prego...");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void LoadingMenu()
        {
            string rowSeparator = new string('-', 100);
            Loading();
            MenuManager.MainMenu();
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
