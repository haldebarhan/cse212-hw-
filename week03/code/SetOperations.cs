using System;
using System.Collections.Generic;

public class SetOperations
{
    public static HashSet<int> Intersection(HashSet<int> setA, HashSet<int> setB)
    {
        HashSet<int> result = new();

        foreach (var item in setA)
        {
            if (setB.Contains(item))
            {
                result.Add(item);
            }
        }

        return result;
    }

    public static HashSet<int> Union(HashSet<int> setA, HashSet<int> setB)
    {
        HashSet<int> result = new();

        foreach (var item in setA)
        {
            result.Add(item);
        }

        foreach (var item in setB)
        {
            result.Add(item);
        }

        return result;
    }
}
