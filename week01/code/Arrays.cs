public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
                // TODO Problem 1 Start
                // Remember: Using comments in your program, write down your process for solving this problem
                // step by step before you write the code. The plan should be clear enough that it could
                // be implemented by another person.
            /// step 1. Create an empty array of doubles and the size is equal to the "length". I will call the array multiples.
            /// step 2. Loop through each index starting with index 0 and up to multiples.Length, not <= multiples.Length.
            /// step 3. At each index, add 1 to the index value and multiply that times "number".  (index + 1) * number
            /// step 4. return the completed array of multiples.
            /// 
        double[] multiples = new double[length];
        for (var index = 0; index < multiples.Length; index++)
        {
            multiples[index] = (index + 1) * number;
        }
        return multiples; 
        
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person

        ///step 1. Get the amount from the data and slice the list.
        ///step 2. Rotate 'data' to the right by the amount given in the parameter but slicing the list at amount
        ///step 3. Get the remaining data items and they are now at the back of the list. 
        ///step 4. use data.Clear() to clear the #pragma warning disable format
        ///step 5. append the end portion that was removed after the "amount" and it is now first in the list.
        ///step 6. append the front portion that was before the "amount" and now it is at the back of the list.

        List<int> endList = data.GetRange(data.Count - amount, amount);
        List<int> frontList = data.GetRange(0, data.Count - amount);
        data.Clear();
        data.AddRange(endList);
        data.AddRange(frontList);
    }

   
       
    
}
