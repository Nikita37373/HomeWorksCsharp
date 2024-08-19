using System;
using System.Text;
using System.Text.Json;
using System.Threading.Channels;

namespace lesan
{
    class Dictionaryyy
    {
        Dictionary<string, List<string>> dic;
        public string FileName { get; set; }
        public Dictionaryyy(string fileName)
        {
            dic = new Dictionary<string, List<string>>();
            FileName = fileName;
        }
        public void AddWord(string word, List<string> translate)
        {
            dic.Add(word, translate);
        }
        public void ShowDic()
        {
            foreach (KeyValuePair<string, List<string>> item in dic)
            {
                Console.Write(item.Key + " - ");
                foreach (var tr in item.Value)
                {
                    Console.Write(tr + " ");
                }
                Console.WriteLine();
            }
        }
        public void GetTranslate(string word)
        {
            if (dic.ContainsKey(word))
                foreach (var tr in dic[word])
                {
                    Console.Write(tr + " ");
                }
            else
                Console.WriteLine("Haven't this word");
            Console.WriteLine();
        }
        public void Remove(string word)
        {
            if (dic.ContainsKey(word))
                dic.Remove(word);
            else
                Console.WriteLine("Haven't this word");
        }
        public void AddTranslate(string word, string translate)
        {
            if (dic.ContainsKey(word))
                dic[word].Add(translate);
            else
                Console.WriteLine("Haven't this word");
        }
        public void RemoveTranslate(string word, string translate)
        {
            if (dic.ContainsKey(word))
            {
                dic[word].Remove(translate);

            }
            else
                Console.WriteLine("Haven't this word");

        }
        public void ChangeWord(string word, List<string> translate)
        {
            dic.Remove(word);
            dic.Add(word, translate);
        }
        public void WriteToFile()
        {
            string jsonString = JsonSerializer.Serialize(dic);
            File.WriteAllText(FileName, jsonString);
            Console.WriteLine("JsonSerializer serializable is OK!!!!");
        }
        public void ReadFromFile()
        {
            string jsonString = File.ReadAllText(FileName);
            dic = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(jsonString)!;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionaryyy dictionary = new Dictionaryyy("Dictionary.json");
            string word, word1, word2, word3,word4, word5;
            string transl , transl1, transl2, transl3;
            List<string> translatee = new List<string>();
            int count = 0;
            int count1 = 0;
            int key = 1;
            

            do
            {
                Console.WriteLine("English-Ukrainian dictionary ");
                Console.WriteLine("Enter your choise :");
                Console.WriteLine("\t1 - Show dictionary");
                Console.WriteLine("\t2 - Add new word");
                Console.WriteLine("\t3 - Remove word");
                Console.WriteLine("\t4 - Get translate");
                Console.WriteLine("\t5 - Add translate");
                Console.WriteLine("\t6 - Remove translate");
                Console.WriteLine("\t7 - Change translate");
                Console.WriteLine("\t8 - Write to file");
                Console.WriteLine("\t9 - Read from file ");
                Console.WriteLine("\t10 - Close");
                key = int.Parse(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        dictionary.ShowDic();
                        break;
                    case 2:
                        Console.WriteLine("Enter word and translate ");
                        word = Console.ReadLine();
                        count = int.Parse(Console.ReadLine());
                        transl = "";
                        for (int i = 0; i < count; i++)
                        {
                            transl = Console.ReadLine();
                            translatee.Add(transl);
                        }
                        
                        dictionary.AddWord(word, translatee);
                        break;
                    case 3:
                        Console.WriteLine("Enter word ");
                        word1 = Console.ReadLine();
                        dictionary.Remove(word1);
                        break;
                    case 4:
                        Console.WriteLine("Enter word ");
                        word2 = Console.ReadLine();
                        dictionary.GetTranslate(word2);
                        break;
                    case 5:
                        Console.WriteLine("Enter word ");
                        word3 = Console.ReadLine();
                        Console.WriteLine("Enter translate");
                        transl1 = Console.ReadLine();
                        dictionary.AddTranslate(word3, transl1);
                        break;
                    case 6:
                        Console.WriteLine("Enter word ");
                        word4 = Console.ReadLine();
                        Console.WriteLine("Enter translate");
                        transl2 = Console.ReadLine();
                        dictionary.RemoveTranslate(word4, transl2);
                        break;
                    case 7:
                        Console.WriteLine("Enter word and new translate ");
                        word5 = Console.ReadLine();
                        count1 = int.Parse(Console.ReadLine());
                        for (int i = 0; i < count1; i++)
                        {
                            transl3 = Console.ReadLine();
                            translatee.Add(transl3);
                        }
                        dictionary.ChangeWord(word5, translatee);
                        break;
                    case 8:
                        dictionary.WriteToFile();
                        break;
                    case 9:
                        dictionary.ReadFromFile();
                        break;
                    case 10:
                        break;
                }



            } while (key != 10);

            //dictionary.AddWord("Desert", new List<string> { "Pystelia", "Zalishatu" });
            //dictionary.AddWord("Water", new List<string> { "Voda", "Vodniy" });
            //dictionary.AddWord("Apple", new List<string> { "Iablyko", "Iablychniy" });
            //dictionary.ShowDic();
            //dictionary.GetTranslate("Apple");
            //dictionary.Remove("Apple");
            //dictionary.ShowDic();
            //dictionary.AddTranslate("Water", "Vodichka");
            //dictionary.ShowDic();
            //dictionary.RemoveTranslate("Water", "Vodichka");
            //dictionary.ShowDic();
            //dictionary.ChangeWord("Water", new List<string> { "Iablyko", "Iablychniy11111111" });
            //dictionary.ShowDic();
            //dictionary.WriteToFile();
            //dictionary.ReadFromFile();
















        }
    }
}
