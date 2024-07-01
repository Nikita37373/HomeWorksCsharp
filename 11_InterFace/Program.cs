using System.Text;

namespace _11_InterFace
{
    abstract class Human
    {
        public string FName { get; set; }
        public string SName { get; set; }
        public DateTime Birthday { get; set; }
        public override string ToString()
        {
            return $"Fullname : {SName} {FName}. Birthday : {Birthday.ToShortDateString()}";


        }
    }
    abstract class Employee : Human
    {
        public string Position { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"\n Position : {Position}. Salary : {Salary}";

        }
    }
    interface IWorkable
    {
        bool IsWorking { get; }
        string Work();
    }
    interface IManager
    {
        List<IWorkable> ListOfWorkers { get; set; }
        void Organize();
        void Control();
        void MakeBudget();

    }
    class Director : Employee, IManager
    {
        public List<IWorkable> ListOfWorkers { get; set; }
        public void Control()
        {
            Console.WriteLine("I control work");
        }

        public void MakeBudget()
        {
            Console.WriteLine("I make budget");
        }
        public void Organize()
        {
            Console.WriteLine("I organize work");
        }
    }
    class Seller : Employee, IWorkable
    {
        public bool IsWorking => true;
        public string Work()
        {
            return "I selling product";
        }
    }
    class Cashier : Employee, IWorkable
    {
        public bool IsWorking => true;
        public string Work()
        {
            return "I get pay for product";
        }
    }
    class Administrator : Employee, IWorkable, IManager
    {
        public bool IsWorking => true;

        public List<IWorkable> ListOfWorkers { get; set; }

        public void Control()
        {
            Console.WriteLine("I am a BOSSSS.....");
        }

        public void MakeBudget()
        {
            Console.WriteLine("I am rich!!! I have a lot of money!!!");
        }

        public void Organize()
        {
            Console.WriteLine("I organize work");
        }

        public string Work()
        {
            return "I  do my work again ((((((";
        }
    }


    interface IOutput
    {
        void Show();
        void Show(string info);

    }
    interface IMath
    {
        int Max();
        int Min();
        int Avg();
        bool Search(int valueToSearch);
    }
    interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }
    class Arrey : IOutput, IMath, ISort
    {
        Random random = new Random();
        int[] arrey;
        public Arrey(int size)
        {
            arrey = new int[size];
            for (int i = 0; i < arrey.Length; i++)
            {
                arrey[i] = random.Next(0,100);
            }
        }
        public void Show()
        {
            for (int i = 0; i < arrey.Length; i++)
            {
                Console.Write(arrey[i] + " ");
            }
            Console.WriteLine();
        }
        public void Show(string info)
        {
            for (int i = 0; i < arrey.Length; i++)
            {
                Console.Write(arrey[i] + " ");
            }
            Console.WriteLine(info);
            Console.WriteLine();
        }
        public int Max()
        {
            return arrey.Max();
        }
        public int Min()
        {
            return arrey.Min();
        }
        public int Avg()
        {
            return (int)arrey.Average();
        }
        public bool Search(int valueToSearch)
        {
            for (int i = 0; i < arrey.Length; i++)
            {
                if (arrey[i] == valueToSearch)
                    return true;
                else
                    return false;
            }
            return false;
        }
        public void SortAsc()
        {
            Array.Sort(arrey);
        }
        public void SortDesc()
        {
            SortAsc();
            Array.Reverse(arrey);
            
        }
        public void SortByParam(bool isAsc)
        {
            if (isAsc)
                SortAsc();
            else
                SortDesc();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            Arrey arrey = new Arrey(size);
            arrey.Show();
            arrey.Show("Privet mama");
            Console.WriteLine(arrey.Max());
            Console.WriteLine(arrey.Min());
            Console.WriteLine(arrey.Avg());
            arrey.SortAsc();
            arrey.Show();
            arrey.SortDesc();
            arrey.Show();
            arrey.SortByParam(true);
            arrey.Show();








            ////Director director = new Director()
            //IManager director = new Director()
            //{
            //    FName = "Stepan",
            //    SName = "Bandera",
            //    Birthday = new DateTime(1982, 12, 1),
            //    Position = "Director",
            //    Salary = 100000
            //};
            //director.Control();
            //director.Organize();
            //director.MakeBudget();
            //Console.WriteLine(director);
            ////Seller seller = new Seller()
            //IWorkable seller = new Seller()
            //{
            //    FName = "oleg",
            //    SName = "Varelovich",
            //    Birthday = new DateTime(1999, 12, 1),
            //    Position = "Seller",
            //    Salary = 130
            //};
            //Console.WriteLine(seller);



            //director.ListOfWorkers = new List<IWorkable>
            //{
            //    seller,
            //    new Cashier
            //    {
            //        FName = "oleg",
            //        SName = "Varelovich",
            //        Birthday = new DateTime(1999, 12, 1),
            //        Position = "Seller",
            //        Salary = 130213
            //    },
            //    new Seller
            //    {
            //        FName = "oleg",
            //        SName = "Varelovich",
            //        Birthday = new DateTime(1999, 12, 1),
            //        Position = "Seller",
            //        Salary = 13033
            //    },
            //    new Administrator
            //    {
            //        FName = "oleger",
            //        SName = "Varelovich",
            //        Birthday = new DateTime(1999, 12, 1),
            //        Position = "Seller",
            //        Salary = 13033
            //    }
            //};
            //foreach(IWorkable emp in director.ListOfWorkers)
            //{
            //    Console.WriteLine(emp.Work());
            //    if (emp is Cashier)
            //        Console.WriteLine("THis is CAshier");
            //    if (emp is Administrator)
            //        (emp as Administrator).Control();
            //}

            //Administrator admin = new Administrator();
            //IManager manager = admin;
            //manager.Control();
            //IWorkable worker = admin;
            //worker.Work();



        }
    }
}
