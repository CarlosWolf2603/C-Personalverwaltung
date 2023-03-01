using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perso
{
    using System;
    using System.Collections.Generic;

    namespace Personenverwaltung
    {
        class Person
        {
            public string Vorname { get; set; }
            public string Nachname { get; set; }
            public DateTime Geburtsdatum { get; set; }
            public string Adresse { get; set; }
            public string Email { get; set; }

            public Person(string vorname, string nachname, DateTime geburtsdatum, string adresse, string email)
            {
                Vorname = vorname;
                Nachname = nachname;
                Geburtsdatum = geburtsdatum;
                Adresse = adresse;
                Email = email;
            }
        }

        class Program
        {
            static List<Person> personenListe = new List<Person>();

            static void Main(string[] args)
            {
                bool beenden = false;
                while (!beenden)
                {
                    Console.WriteLine("Was möchten Sie tun?");
                    Console.WriteLine("1 - Neue Person hinzufügen");
                    Console.WriteLine("2 - Alle Personen anzeigen");
                    Console.WriteLine("3 - Beenden");
                    string auswahl = Console.ReadLine();

                    switch (auswahl)
                    {
                        case "1":
                            NeuePersonHinzufuegen();
                            break;
                        case "2":
                            AllePersonenAnzeigen();
                            break;
                        case "3":
                            beenden = true;
                            break;
                        default:
                            Console.WriteLine("Bitte überprüfen Sie Ihre Eingabe.");
                            break;
                    }
                }
            }

            static void NeuePersonHinzufuegen()
            {
                Console.WriteLine("Bitte geben Sie die Daten der Person ein, die Sie speichern möchten:");
                Console.Write("Vorname: ");
                string vorname = Console.ReadLine();
                Console.Write("Nachname: ");
                string nachname = Console.ReadLine();
                Console.Write("Geburtsdatum (Format TT.MM.JJJJ): ");
                DateTime geburtsdatum = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
                Console.Write("Adresse: ");
                string adresse = Console.ReadLine();
                Console.Write("E-Mail-Adresse: ");
                string email = Console.ReadLine();

                Person neuePerson = new Person(vorname, nachname, geburtsdatum, adresse, email);
                personenListe.Add(neuePerson);
                Console.WriteLine("Die Person wurde hinzugefügt.");
            }

            static void AllePersonenAnzeigen()
            {
                Console.WriteLine("Alle Personen:");
                foreach (Person person in personenListe)
                {
                    Console.WriteLine($"{person.Vorname} {person.Nachname} ({person.Geburtsdatum.ToString("dd.MM.yyyy")})");
                    Console.WriteLine($"  Adresse: {person.Adresse}");
                    Console.WriteLine($"  E-Mail-Adresse: {person.Email}");
                }
            }
        }
    }
}

