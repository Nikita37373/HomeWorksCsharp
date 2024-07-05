using System.Text;
using System.Xml.Linq;
using System.Xml.Schema;

namespace _16_Dictionary
{ 
    class User
    {
        public string Name{ get; set; }
    }
    class PhoneBook
    {
        Dictionary<string, string> dic;
        public PhoneBook()
        {
            dic = new Dictionary<string, string>();
        }
        public void AddPhone(string num, string name)
        {
            dic[num] = name;
        }
        public void ZminaPhone(string num, string name)
        {
            foreach (var item in dic.Keys)
            {
                if (item == num)
                {
                    dic[item] = name;
                }
            }
        }
        public void Search(string num)
        {
            foreach (var item in dic.Keys)
            {
                if (item == num)
                {
                    Console.WriteLine(item);
                    Console.WriteLine(dic[item]);
                }
            }
        }
        public void Remove(string num)
        {
            foreach (var item in dic.Keys)
            {
                if (item == num)
                {
                    dic.Remove(item);
                }
            }
        }
        public void Show()
        {
            foreach(KeyValuePair<string, string> item in dic)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }

    }
    class Statistic
    {
        Dictionary<string, int> dic;
        public Statistic()
        {
            dic = new Dictionary<string, int>();
        }
        public void AddWord(string[] words)
        {
            
            foreach (var item in words)
            {
                if (dic.ContainsKey(item))
                    dic[item]++;
                else
                    dic.Add(item, 1);
            }
            
            
        }
        public void Show()
        {
            Console.WriteLine("Words : " + " Count : ");
            foreach (var item in dic)
            {
                
                Console.WriteLine(item.Value + " " + item.Key);
            }
            Console.WriteLine("Count all words = 36 ");
            Console.WriteLine("Count original words = 9 ");
        }

    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Statistic stat = new Statistic();
            //stat.AddWord("Privet");
            string word = "Ось будинок, який збудував Джек. А це пшениця, яка " +
                "у темній коморі зберігається у будинку, який збудував Джек. " +
                "А це веселий птах-синиця, який часто краде пшеницю, " +
                "яка в темній коморі зберігається у будинку, який збудував Джек.";
            string[] words = word.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
            stat.AddWord(words);
            stat.Show();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            PhoneBook phonebook = new PhoneBook();
            phonebook.AddPhone("+380222222", "NIkita");
            phonebook.AddPhone("+380333333", "Stepan");
            phonebook.AddPhone("+380777777", "Valera");
            phonebook.Show();
            phonebook.ZminaPhone("+380333333", "Nastya");
            phonebook.Show();
            phonebook.Search("+380777777");

            phonebook.Remove("+380333333");
            phonebook.Show();









            //Dictionary<string, string> dic = new Dictionary<string, string>();
            //dic.Add("UA", "Ukraine");
            //dic.Add("USA", "Omerica");
            //dic.Add("UK", "United Kindom");
            //dic.Add("FR", "France");
            //dic.Add("IT", "Italy");

            //foreach (KeyValuePair<string,string> item in dic)
            //{
            //    Console.WriteLine(item.Key+ " "+ item.Value);
            //}
            //string country = dic["USA"];
            //Console.WriteLine(country);
            //Console.WriteLine();
            //dic["USA"] = "America";
            //dic["IN"] = "India";
            //dic.Remove("FR");
            //foreach (KeyValuePair<string, string> item in dic)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //Dictionary<char,User> people =  new Dictionary<char,User>();
            //people.Add('b', new User() { Name = "Bob" });  
            //people.Add('t', new User() { Name = "Tom" });  
            //people.Add('j', new User() { Name = "Jack" });  
            //people.Add('r', new User() { Name = "Rita" });

            //if (people.ContainsKey('r'))
            //{
            //    people['r'].Name = "Roma";
            //}
            //foreach (KeyValuePair<char, User> item in people)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value.Name);
            //}
            //foreach (var item in people.Keys)
            //{
            //    Console.WriteLine(item);
            //}
        }
    } 
}
