public static class Arrays
{
    public static double[] MultiplesOf(double number, int length)
    {
        // First, create an array "results" with a size corresponding to the value of param "length"
        // then run a loop from 1 to length 
        // add each multiplication of the number by the index to index -1 of the results array (arrays start at index 0)
        // return results

        double[] results = new double[length];
        for (int index = 1; index <= length; index++)
        {
            results[index - 1] = number * index;
        }

        return results;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: find the position of the last indexes in the pheasant list list size reduced by amount
        // Step 2: extract the last values from the list and insert them in a new list
        // Step 3: delete the last values in the original list
        // Step 4: add the data extracted in step 2 to the beginning (at index 0) of the original list
        int position = data.Count - amount;
        List<int> Last_values = data.GetRange(position, amount);
        data.RemoveRange(position, amount);
        data.InsertRange(0, Last_values);

    }
}
