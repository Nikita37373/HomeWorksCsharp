namespace _01_Homework
{
    internal class Program
    {
        static bool IsPalindrom(char[] word)
        {
            for (int i = 0; i < word.Length / 2; i++)
                if (word[i] != word[word.Length - 1 - i])
                    return false;
            return true;
        }

        static void Main(string[] args)
        {
            
            //Console.WriteLine("Введіть рядок : ");
            //String word = Console.ReadLine();
            //char[] wordd = word.ToCharArray();
            //if (IsPalindrom(wordd))
            //    Console.WriteLine("palindrom");
            //else
            //    Console.WriteLine("no palindrom");


            string text = "Hello How Many big LEtter in This text";
            int countUp = 0;
            int countDown = 0;  
            foreach (char item in text)
            {
                if (char.IsUpper(item))
                {
                    countUp++;
                }
                if (char.IsLower(item))
                {
                    countDown++;
                }
            }
            Console.WriteLine(countUp +" "+ countDown);


        }
        
    }
}

