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
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    FindMostCommonWeapon(terrorists);
                    break;
                case "2":
                    FindLeastCommonWeapon(terrorists);
                    break;
                case "3":
                    FindOrgWithMostMembers(terrorists);
                    break;
                case "4":
                    FindOrgWithLeastMembers(terrorists);
                    break;
                case "5":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1, 2, 3, 4, or 5.");
                    break;
            }
        }
    }

    static void FindMostCommonWeapon(List<Terrorist> terrorists)
    {
        Dictionary<string, int> weaponCounts = new Dictionary<string, int>();

        foreach (var terrorist in terrorists)
        {
            foreach (var weapon in terrorist.Weapons)
            {
                if (weaponCounts.ContainsKey(weapon))
                {
                    weaponCounts[weapon]++;
                }
                else
                {
                    weaponCounts[weapon] = 1;
                }
            }
        }

        string mostCommonWeapon = null;
        int maxCount = 0;

        foreach (var pair in weaponCounts)
        {
            if (pair.Value > maxCount)
            {
                mostCommonWeapon = pair.Key;
                maxCount = pair.Value;
            }
        }

        if (mostCommonWeapon != null)
        {
            Console.WriteLine($"Most common weapon is: {mostCommonWeapon} ({maxCount} times)");
        }
        else
        {
            Console.WriteLine("No weapons found.");
        }
    }

    static void FindLeastCommonWeapon(List<Terrorist> terrorists)
    {
        Dictionary<string, int> weaponCounts = new Dictionary<string, int>();

        foreach (var terrorist in terrorists)
        {
            foreach (var weapon in terrorist.Weapons)
            {
                if (weaponCounts.ContainsKey(weapon))
                {
                    weaponCounts[weapon]++;
                }
                else
                {
                    weaponCounts[weapon] = 1;
                }
            }
        }

        string leastCommonWeapon = null;
        int minCount = int.MaxValue;

        foreach (var pair in weaponCounts)
        {
            if (pair.Value < minCount)
            {
                leastCommonWeapon = pair.Key;
                minCount = pair.Value;
            }
        }

        if (leastCommonWeapon != null)
        {
            Console.WriteLine($"Least common weapon is: {leastCommonWeapon} ({minCount} times)");
        }
        else
        {
            Console.WriteLine("No weapons found.");
        }
    }

    static void FindOrgWithMostMembers(List<Terrorist> terrorists)
    {
        int hamasCount = 0;
        int jihadCount = 0;

        foreach (var terrorist in terrorists)
        {
            if (terrorist.Affiliation == "Hamas")
                hamasCount++;
            else if (terrorist.Affiliation == "Islamic Jihad")
                jihadCount++;
        }

        if (hamasCount > jihadCount)
        {
            Console.WriteLine($"The organization with the most members is: Hamas ({hamasCount} members)");
        }
        else if (jihadCount > hamasCount)
        {
            Console.WriteLine($"The organization with the most members is: Islamic Jihad ({jihadCount} members)");
        }
        else
        {
            Console.WriteLine($"Both organizations have the same number of members ({hamasCount} each)");
        }
    }

    static void FindOrgWithLeastMembers(List<Terrorist> terrorists)
    {
        int hamasCount = 0;
        int jihadCount = 0;

        foreach (var terrorist in terrorists)
        {
            if (terrorist.Affiliation == "Hamas")
                hamasCount++;
            else if (terrorist.Affiliation == "Islamic Jihad")
                jihadCount++;
        }

        if (hamasCount < jihadCount)
        {
            Console.WriteLine($"The organization with the least members is: Hamas ({hamasCount} members)");
        }
        else if (jihadCount < hamasCount)
        {
            Console.WriteLine($"The organization with the least members is: Islamic Jihad ({jihadCount} members)");
        }
        else
        {
            Console.WriteLine($"Both organizations have the same number of members ({hamasCount} each)");
        }
    }
}