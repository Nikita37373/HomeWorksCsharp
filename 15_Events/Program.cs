namespace _15_Events
{

    public delegate void ActionDelegate();
    public delegate void ExamDelegate(string t);
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public void PassExam(string task)
        {
            Console.WriteLine($"Student : {FirstName} {LastName} pass the exam {task}");

        }
    }
    class Teacher
    {
        public event Action TestEvent;

        private ExamDelegate examDelegate;
        public event ExamDelegate ExamDelegate
        {
            add
            {
                examDelegate += value;
                Console.WriteLine(value.Method.Name + " was added");
            }
            remove
            {
                examDelegate -= value;
                Console.WriteLine(value.Method.Name + " was removed");
            }

        }
        public void CreateExam(string t)
        {
            examDelegate?.Invoke(t);
        }
        public void TestAction()
        {
            TestEvent?.Invoke();
        }
    }

    static class Name
    {
        public static bool IsPalindrom(this string data)
        {
            for (int i = 0; i < data.Length / 2 ; i++)
            {
                if (data[i] != data[data.Length - 1 - i])
                    return false;
            }
            return true;
        }
        public static void Shifr(this string date, int key)
        {
            string shifr = "";
            
            for (int i = 0; i < date.Length; i++)
            {
                shifr+=Convert.ToChar(date[i] + key);
            }
            Console.WriteLine(shifr);
        }
        public static int CountOdnakovuh(this int[] date, int num)
        {
            int count = 0;
            for (int i = 0; i < date.Length; i++)
            {
                if (date[i] == num)
                {
                    count++;
                }
            }
            return count;
        }
    }



    internal class Program
    {
       
        static void Main(string[] args)
        {
            string name = "natan";
            Console.WriteLine(name.IsPalindrom());

            string words = "Hello";
            words.Shifr(3);

            int[] word = {1,2,3,4,5,2,2,2 };
            Console.WriteLine(word.CountOdnakovuh(2)); 









            //List<Student> students = new List<Student>
            //{
            //    new Student
            //    {
            //         FirstName = "Olga",
            //         LastName = "Ivanchuk",
            //         Birthday = new DateTime(2000, 5,7),
            //    },
            //     new Student
            //    {
            //         FirstName = "Bob",
            //         LastName = "Sincler",
            //         Birthday= new DateTime(2002,12,17),
            //    },
            //      new Student
            //    {
            //         FirstName = "Elis",
            //         LastName = "Holms",
            //         Birthday = new DateTime(2004, 7,12),
            //    },
            //         new Student
            //    {
            //         FirstName = "Petro",
            //         LastName = "Petruk",
            //         Birthday = new DateTime(2004, 7,12),
            //    }
            //};
            //Teacher teacher = new Teacher();
            //foreach (Student st in students)
            //{
            //    teacher.ExamDelegate += st.PassExam;
            //}
            //teacher.ExamDelegate -= students[3].PassExam;
            ////teacher.ExamDelegate = null;
            //teacher.CreateExam("C# exam at 18 oclock 27.04.2024 in 36 auditory");

            //teacher.TestEvent += Console.Clear;
            //teacher.TestEvent -= Console.Clear;
            //teacher.TestEvent += delegate() { Console.ForegroundColor = ConsoleColor.Cyan; };
            //teacher.TestEvent += delegate() { Console.BackgroundColor = ConsoleColor.Red; };
            //teacher.TestEvent += () => Console.Beep(100 , 500);
            //teacher.TestEvent += Teacher_TestEvent;

            //teacher.TestAction();





            //HardWork(Action1);
            //HardWork(Action2);
            //HardWork(Action3);
            //HardWork(null);
        }
        private static void Teacher_TestEvent()
        {
            Console.WriteLine("Auto created by pressing tab");
        }
        static void HardWork(ActionDelegate action)
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Operation {i + 1} working.....");
                Thread.Sleep(random.Next(500));
                Console.WriteLine($"Operation {i + 1} finished.....");
            }
            action?.Invoke();
        }
        static void Action1()
        {
            Console.WriteLine("You are a good worker");
        }
        static void Action2()
        {
            Console.WriteLine("You are a normal worker");
        }
        static void Action3()
        {
            Console.WriteLine("You are loser");
        }
    }
}
