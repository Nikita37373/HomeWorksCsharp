namespace _03_Enum
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string name = null, lastname = null;
            name = "Petro";
            lastname = "Ivanchyk";

            name = "Mukola";

            string fullname = name + "   " + lastname;
            Console.WriteLine(fullname);
            Console.WriteLine($"Fullname : {fullname}");

            string str = new string("Hello");
            //string str1 = "world";
            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string greeting = new string(letters, 0, letters.Length);
            Console.WriteLine("Greeting : {0} {1} {2}", greeting, 100, "Good");

            string[] words = { "Hello", "good", "summer", "white", "point" };
            string message = string.Join(" - ", words);
            Console.WriteLine($"Message : {message}");

            string[]splitArr = message.Split(new string[] { " - " }, StringSplitOptions.None);
            foreach(string s in splitArr)
            {
                Console.WriteLine(s);
            }
            string htmlMessage = "HTML is a standardized document markup language for viewing " +
               "web pages in a browser. Browsers receive an HTML document from the " +
               "server using HTTP/HTTPS protocols or open it from a local disk, " +
               "then interpret the code into the interface that will be displayed " +
               "on the monitor screen. ";
            string[] messWords = htmlMessage.Split(new char[] { ' ', '.', ',', '?', '!', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach(string s in messWords)
            {
                Console.WriteLine("|" + s + "|");
            }
        }
    }
}
