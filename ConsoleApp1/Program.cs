namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = { "apple", "banana", "cat", "dog", "elephant", "fo", "goat" };

            
        }

        static string[] FilterStrings(string[] array)
        {        
            string[] filteredArray = new string[array.Length];
            int count = 0;        
            foreach (string str in array)
            {
                
                if (str.Length <= 3)
                {                   
                    filteredArray[count] = str;
                    count++;
                }
            }           
            string[] resultArray = new string[count];
            for (int i = 0; i < count; i++)
            {
                resultArray[i] = filteredArray[i];
            }
            return resultArray;
        }

        static void PrintArray(string[] array)
        {
            foreach (string str in array)
            {
                Console.WriteLine(str);
            }
        }
    }
}