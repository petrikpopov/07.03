using System;
using System.Collections.Generic;
using System.Linq;


namespace LINQ
{
    class Person
    {
        public string Name_P { set; get; }
        public string Job { set; get; }
        public string Nomber_Telephone { set; get; }
        public string Email { set; get; }
        public int Price { set; get; }

        public Person() { }
        public Person(string NP, string J, string NT, string E, int P)
        {
            Name_P = NP;
            Job = J;
            Nomber_Telephone = NT;
            Email = E;
            Price = P;
        }
    }

    class Firma
    {
        public string Name_Firma { set; get; }
        public int Date_Osnov { set; get; }
        public string Profil_Firma { set; get; }
        public string NAme_Director { set; get; }
        public int Count_Persone { set; get; }
        public string Adres { set; get; }

        public Firma() { }
        public Firma(string NF, int DO, string PF, string ND, int CP, string A)
        {
            Name_Firma = NF;
            Date_Osnov = DO;
            Profil_Firma = PF;
            NAme_Director = ND;
            Count_Persone = CP;
            Adres = A;
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            List<Person> people = new List<Person>()
            {
                new Person("Petro","Programmer","09876543","opvjf90@gmail.com",1000),
                new Person("Oleg","Meneger","098765432","poiuyt7@gmail.com",1200 ),
                new Person("Vika","Designer","0987876533","dikayb5@gmail.com",800),
                new Person("Vlad","Admin","09845673","vLadfor3@gmail.com",2000),
                
            };
            List<Firma> list = new List<Firma>()
            {
                new Firma{Name_Firma="DP World\t",Date_Osnov = 1980, Profil_Firma="Logist\t", NAme_Director="Шейх\t", Count_Persone = 110, Adres = "OAE\t"},
                new Firma{Name_Firma="SeaRates\t",Date_Osnov = 2004, Profil_Firma="Logist\t", NAme_Director="Sergey\t", Count_Persone = 100, Adres = "Gogoly 23\t" },
                new Firma{Name_Firma="Roshen  \t",Date_Osnov = 2000, Profil_Firma="Conditer\t", NAme_Director="Petro\t", Count_Persone = 500, Adres = "Ukraina\t" }
            };
            var Rez = from i in list
                      select i;
            foreach (var a in Rez)
            {
                Console.Write(a.Name_Firma, "\n");
                Console.Write(a.Date_Osnov);
                Console.Write(a.Profil_Firma);
                Console.Write(a.NAme_Director);
                Console.Write(a.Count_Persone);
                Console.Write(a.Adres);
                Console.WriteLine();
            }
            Console.WriteLine("\n");

            var R = from i in people
                    select i;
            foreach (var i in people)
            {
                Console.WriteLine(i.Name_P);
                Console.WriteLine(i.Job);
                Console.WriteLine(i.Nomber_Telephone);
                Console.WriteLine(i.Email);
                Console.WriteLine(i.Price);
                
            }
            Console.WriteLine("\n");

            int A = Console.Read();

            var P = people.Where(p => p.Price > A);

            foreach (var i in P)
            {
                Console.WriteLine($"{i.Name_P}");
            }

            var M = people.Where(m => m.Job.Contains("Meneger"));

            foreach (var i in M)
            {
                Console.WriteLine($"{i.Name_P}");
            }
            var Em = people.Where(E => E.Email.StartsWith("di"));

            foreach (var i in Em)
            {
                Console.WriteLine($"{i.Name_P}");
            }

            var Ph = people.Where(p => p.Nomber_Telephone.StartsWith("23"));

            foreach (var i in Ph)
            {
                Console.WriteLine($"{i.Name_P}");
            }

            var Name = people.Where(N => N.Name_P.Contains("Lionel"));

            foreach (var i in Name)
            {
                Console.WriteLine($"{i.Name_P}");
            }

            var Food = list.Where(l => l.Name_Firma.Contains("Roshen"));

            foreach (var i in Food)
            {
                Console.WriteLine($"Firma --> {i.Name_Firma}");
            }
            Console.WriteLine();

            var Job = list.Where(l => l.Profil_Firma.Contains("Logist"));

            foreach (var i in Job)
            {
                Console.WriteLine($"Logist Firma --> {i.Name_Firma}");
            }

            var JobIT = list.Where(l => l.Profil_Firma.Contains("Logist") && l.Profil_Firma.Contains("IT"));

            foreach (var i in JobIT)
            {
                Console.WriteLine($"Logist/IT firma{i.Name_Firma}");
            }

            var PersonCount = list.Where(l => l.Count_Persone > 100 && l.Count_Persone<300);
             
            foreach (var i in PersonCount)
            {
                Console.WriteLine($"Name firma ---> {i.Name_Firma}");
            }

            var London = list.Where(l=>l.Adres.Contains("London"));

            foreach (var i in London)
            {
                Console.WriteLine($"Name Firma{i.Adres}");
            }

            var Director = list.Where(l=>l.NAme_Director.Contains("White"));

            foreach (var i in Director)
            {
                Console.WriteLine($"Name Firma{i.NAme_Director}");
            }

            var CountYear = list.Where(l => l.Date_Osnov > 2);

            foreach (var i in CountYear)
            {
                Console.WriteLine($"Name Firma{i.Name_Firma}");
            }


        }
    }
}

    

