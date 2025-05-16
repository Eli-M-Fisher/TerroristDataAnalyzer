using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // List of terrorists
        List<Terrorist> terrorists = new List<Terrorist>
        {
            new Terrorist { Name = "Ali Hassan", Weapons = new List<string>{"M16", "Knife"}, Age = 28, Latitude = 31.52, Longitude = 34.45, Affiliation = "Hamas" },
            new Terrorist { Name = "Sami Jaber", Weapons = new List<string>{"Handgun"}, Age = 35, Latitude = 31.50, Longitude = 34.47, Affiliation = "Islamic Jihad" },
            new Terrorist { Name = "Yousef Darwish", Weapons = new List<string>{"Knife", "Handgun"}, Age = 22, Latitude = 31.49, Longitude = 34.44, Affiliation = "Hamas" },
            new Terrorist { Name = "Khaled Mansour", Weapons = new List<string>{"M16"}, Age = 40, Latitude = 31.53, Longitude = 34.48, Affiliation = "Islamic Jihad" },
            new Terrorist { Name = "Fadi Salim", Weapons = new List<string>{"M16", "Handgun"}, Age = 30, Latitude = 31.51, Longitude = 34.46, Affiliation = "Hamas" },
            new Terrorist { Name = "Omar Khalil", Weapons = new List<string>{"Knife"}, Age = 26, Latitude = 31.54, Longitude = 34.50, Affiliation = "Hamas" },
            new Terrorist { Name = "Ahmed Zidan", Weapons = new List<string>{"Handgun"}, Age = 33, Latitude = 31.55, Longitude = 34.52, Affiliation = "Islamic Jihad" },
            new Terrorist { Name = "Bilal Nazmi", Weapons = new List<string>{"M16"}, Age = 29, Latitude = 31.52, Longitude = 34.49, Affiliation = "Hamas" },
            new Terrorist { Name = "Nidal Fathi", Weapons = new List<string>{"Knife", "Handgun"}, Age = 27, Latitude = 31.50, Longitude = 34.43, Affiliation = "Islamic Jihad" },
            new Terrorist { Name = "Issam Tawfiq", Weapons = new List<string>{"M16"}, Age = 24, Latitude = 31.48, Longitude = 34.41, Affiliation = "Hamas" },
            new Terrorist { Name = "Hassan Muheisen", Weapons = new List<string>{"Knife"}, Age = 31, Latitude = 31.51, Longitude = 34.45, Affiliation = "Islamic Jihad" },
            new Terrorist { Name = "Tariq Omar", Weapons = new List<string>{"Handgun"}, Age = 36, Latitude = 31.53, Longitude = 34.47, Affiliation = "Hamas" },
            new Terrorist { Name = "Mahmoud Ismail", Weapons = new List<string>{"M16", "Knife"}, Age = 38, Latitude = 31.56, Longitude = 34.51, Affiliation = "Islamic Jihad" },
            new Terrorist { Name = "Walid Faraj", Weapons = new List<string>{"Knife"}, Age = 32, Latitude = 31.49, Longitude = 34.42, Affiliation = "Hamas" },
            new Terrorist { Name = "Anas Rami", Weapons = new List<string>{"Handgun", "Knife"}, Age = 23, Latitude = 31.54, Longitude = 34.46, Affiliation = "Islamic Jihad" },
            new Terrorist { Name = "Musa Ayman", Weapons = new List<string>{"M16"}, Age = 34, Latitude = 31.52, Longitude = 34.44, Affiliation = "Hamas" },
            new Terrorist { Name = "Ziad Hatem", Weapons = new List<string>{"M16"}, Age = 30, Latitude = 31.53, Longitude = 34.45, Affiliation = "Islamic Jihad" },
            new Terrorist { Name = "Rami Najjar", Weapons = new List<string>{"Handgun"}, Age = 29, Latitude = 31.51, Longitude = 34.42, Affiliation = "Hamas" },
            new Terrorist { Name = "Adnan Youssef", Weapons = new List<string>{"Knife"}, Age = 25, Latitude = 31.47, Longitude = 34.40, Affiliation = "Islamic Jihad" },
            new Terrorist { Name = "Hisham Fathi", Weapons = new List<string>{"Handgun"}, Age = 28, Latitude = 31.55, Longitude = 34.49, Affiliation = "Hamas" }
        };

        // Quick check
        Console.WriteLine($"Total terrorists loaded: {terrorists.Count}");

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("==== Terrorist Data Analyzer ====");
            Console.WriteLine("1. Find the most common weapon");
            Console.WriteLine("2. Find the least common weapon");
            Console.WriteLine("3. Find the organization with the most members");
            Console.WriteLine("4. Find the organization with the least members");
            Console.WriteLine("5. Find the two closest terrorists");
            Console.WriteLine("6. Search for a terrorist by name");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    TerroristAnalyzer.FindMostCommonWeapon(terrorists);
                    break;
                case "2":
                    TerroristAnalyzer.FindLeastCommonWeapon(terrorists);
                    break;
                case "3":
                    TerroristAnalyzer.FindOrgWithMostMembers(terrorists);
                    break;
                case "4":
                    TerroristAnalyzer.FindOrgWithLeastMembers(terrorists);
                    break;
                case "5":
                    TerroristAnalyzer.FindClosestTerroristPair(terrorists);
                    break;
                case "6":
                    TerroristAnalyzer.SearchTerroristByName(terrorists);
                    break;
                case "7":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1, 2, 3, 4, 5, 6, or 7.");
                    break;
            }
        }
    }
}