using System;
using System.Collections.Generic;

public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary()
    {
        return new Dictionary<int, string>();
    }

    public static Dictionary<int, string> GetExistingDictionary()
    {
        return new Dictionary<int, string>
        {
            {1, "United States of America"},
            {55, "Brazil"},
            {91, "India"}
        };
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        var newDict = GetEmptyDictionary();
        newDict[countryCode] = countryName;
        return newDict;
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        existingDictionary[countryCode] = countryName;
        return existingDictionary;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        string name = "";
        if (CheckCodeExists(existingDictionary, countryCode))
        {
            name = existingDictionary[countryCode];
        }

        return name;
    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        if (existingDictionary.ContainsKey(countryCode))
        {
            return true;
        }
        return false;
    }

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (CheckCodeExists(existingDictionary, countryCode))
        {
            existingDictionary[countryCode] = countryName;
            
        }
        return existingDictionary;
        
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        if (CheckCodeExists(existingDictionary, countryCode))
        {
            existingDictionary.Remove(countryCode);
        }
        return existingDictionary;
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        string LongestName = "";

        foreach (string name in existingDictionary.Values)
        {
            if (name.Length > LongestName.Length)
            {
                LongestName = name;
            }
        }
        return LongestName;
    }
}