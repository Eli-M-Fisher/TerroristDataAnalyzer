

using System;
using System.Collections.Generic;

public static class TerroristAnalyzer
{
    public static void FindMostCommonWeapon(List<Terrorist> terrorists)
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

    public static void FindLeastCommonWeapon(List<Terrorist> terrorists)
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

    public static void FindOrgWithMostMembers(List<Terrorist> terrorists)
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

    public static void FindOrgWithLeastMembers(List<Terrorist> terrorists)
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

    public static void FindClosestTerroristPair(List<Terrorist> terrorists)
    {
        double minDistance = double.MaxValue;
        Terrorist first = null;
        Terrorist second = null;

        for (int i = 0; i < terrorists.Count; i++)
        {
            for (int j = i + 1; j < terrorists.Count; j++)
            {
                double distance = Math.Sqrt(
                    Math.Pow(terrorists[i].Latitude - terrorists[j].Latitude, 2) +
                    Math.Pow(terrorists[i].Longitude - terrorists[j].Longitude, 2)
                );

                if (distance < minDistance)
                {
                    minDistance = distance;
                    first = terrorists[i];
                    second = terrorists[j];
                }
            }
        }

        if (first != null && second != null)
        {
            Console.WriteLine("The two closest terrorists are:");
            Console.WriteLine($"- {first.Name}");
            Console.WriteLine($"- {second.Name}");
            Console.WriteLine($"Distance: {minDistance:F2}");
        }
        else
        {
            Console.WriteLine("Not enough data to determine closest pair.");
        }
    }

    public static void SearchTerroristByName(List<Terrorist> terrorists)
    {
        Console.Write("Enter a name to search: ");
        string input = Console.ReadLine()?.Trim().ToLower();

        bool found = false;

        foreach (var terrorist in terrorists)
        {
            if (terrorist.Name.ToLower().Contains(input))
            {
                found = true;
                Console.WriteLine("Match found:");
                Console.WriteLine($"Name: {terrorist.Name}");
                Console.WriteLine($"Age: {terrorist.Age}");
                Console.WriteLine($"Affiliation: {terrorist.Affiliation}");
                Console.WriteLine($"Weapons: {string.Join(", ", terrorist.Weapons)}");
                Console.WriteLine($"Location: ({terrorist.Latitude}, {terrorist.Longitude})");
                Console.WriteLine();
            }
        }

        if (!found)
        {
            Console.WriteLine("No terrorist found with the given name.");
        }
    }
}