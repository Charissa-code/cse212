public class FirstFindDuplicate
{

    //Find the first duplicate in the collection of data.
    public static void Run()
    {
        string lettersData = "abcdefgehj";
        Console.WriteLine($"The first duplicate is {FindFirstDuplicate(lettersData)}");
    }
        

    //Create HashSet variables. 
    //Loop to find letter in the data.
    //check for membership in the letter data.
    //Add letter to the set
    //When duplicate is found return the letter and position.
    //if no letter or duplicate not found return null
   
    private static char? FindFirstDuplicate(string lettersData)
    {
        var firstFound = new HashSet<char>();
       
        foreach (char letter in lettersData)
        {
            if (firstFound.Contains(letter))
            {
                return letter;
            }

            else
            {
                firstFound.Add(letter); 
            }
        }
        return null;
    }
}
