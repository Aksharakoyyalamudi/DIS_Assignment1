using System;
namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine(RemoveVowels("Akshara"));
            String[] bulls_string1 = { "Marshall", "Student","Center"};
            String[] bulls_string2 = { "MarshallStudent ", "Center"};
            Console.WriteLine(ArrayStringsAreEqual(bulls_string1, bulls_string2));
            int[] bull_bucks = { 1, 2, 3, 4, 5 };
            Console.WriteLine(SumOfUnique(bull_bucks));
            int[,] bulls_grid = new int[,] { { 5 } };
            Console.WriteLine(DiagonalSum(bulls_grid));
            String bulls_string = "codeleet";
            int[] indices = { 4, 5, 6, 7, 0, 2, 1, 3 };
            Console.WriteLine(RestoreString(bulls_string, indices));
            Console.WriteLine(ReversePrefix("Akshara", 's'));



            String RemoveVowels(String input)
            {
                try
                {
                    int n = input.Length;
                    if (n == 0)
                    {
                        Console.WriteLine("empty string");
                    }
                    string s2 = "";
                    Char[] alphabets = { 'a', 'e', 'i', 'o', 'u' };
                    //iterating over all the letters in given input if it is not in the vowels appending to new string. 
                    for (int i = 0; i < n; i++)
                    {
                        if (alphabets.Contains(Char.ToLower(input[i])) == false)
                        {
                            s2 = s2 + input[i];
                        }

                    }

                    return s2;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return input;
                }

            }

            bool ArrayStringsAreEqual(String[] bulls_string1, String[] bulls_string2)
            {
                try
                {
                    
                    int n1 = bulls_string1.Length;
                    int n2 = bulls_string2.Length;
                    String s1 = "";
                    String s2 = "";
                    // if both th estrings are empty returing true.
                    if (n1 == 0 && n2 == 0)
                    {
                        Console.WriteLine("empty strings");
                        return true;
                    }
                    //if any of the string length is more than 1 and the other is 0 then returing false
                    if ((n1 == 0 && n2 > 0) || (n1 > 0 && n2 == 0))
                    {
                        
                        return false;
                    }
                    //iterating over all the words in given string array and appending to a string.
                    for (int i = 0; i < bulls_string1.Length; i++)
                    {
                        

                        s1 = s1 + bulls_string1[i].Trim();
                    }
                    //iterating over all the words in given string array and appending to a string.
                    for (int i = 0; i < bulls_string2.Length; i++)
                        s2 = s2 + bulls_string2[i].Trim();
                    
                    //comparing both the new strings.if equal then return true else return false.
                    if (String.Equals(s1, s2))
                    {
                        return true;
                    }
                    else
                        return false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return false;
                }

            }

            int SumOfUnique(int[] bull_bucks)
            {
                try
                {
                    int s = 0;
                    for (int i = 0; i < bull_bucks.Length; i++)
                    {
                        //using the arrow function to count the occurences of the number in the array. if it is 1 then add
                        //the number to the new integer variable.
                        if (bull_bucks.Count(x => x == bull_bucks[i]) == 1)
                        {
                            s += bull_bucks[i];
                        }
                    }
                    return s;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return 0;
                }

            }

            int DiagonalSum(int[,] bulls_grid)
            {
                try
                {
                    int s = 0;
                    
                    int n = bulls_grid.GetLength(1);

                    //iterating over the length of the first array and taking the diagnols from starting to ending if 
                    //comes the situation where both are equal then add only once.
                    for (int i = 0; i < n; i++)
                    {

                        if (i == n - i - 1)
                        {
                            s += bulls_grid[i, i];
                        }
                        else
                        {
                            s += bulls_grid[i, i];
                            s += bulls_grid[i, n - i - 1];
                        }
                    }
                    return s;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return 0;
                }

            }


            String RestoreString(string bulls_string, int[] indices)
            {
                try
                {
                    //maintaining the dictionary to use the index as the key and the string as the value.
                    //by ordering keys selecting the corresponding values and appending to string
                    string s = string.Empty;
                    if (bulls_string.Length == indices.Length && indices.Length < 100)
                    {
                        Dictionary<int, char> dict = new Dictionary<int, char>();
                        char[] arr = bulls_string.ToCharArray();
                        for (int i = 0; i < arr.Length; i++)
                            dict.Add(indices[i], arr[i]);
                        var k = from i in dict orderby i.Key ascending select i.Value;
                        foreach (var ch in k)
                            s += ch.ToString();
                    }
                    return s;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return bulls_string;
                }

            }


            String ReversePrefix(string bulls_string, char ch)
            {
                try
                {
                    String s = "";
                    //by taking the index of the given char and iterating the string from that index to the start of the
                    //string adding to the new string and appending the remaining input string to new string.
                    if (bulls_string.Contains(ch))
                    {
                        int j = bulls_string.IndexOf(ch);
                        for (int i = j; i >= 0; i--)
                        {
                            s += bulls_string[i];
                        }
                        s += bulls_string.Substring(j + 1);
                        return s;
                    }
                    return bulls_string;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return bulls_string;
                }

            }

        }
    }
}