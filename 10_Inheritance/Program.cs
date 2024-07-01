using System;

namespace _10_Inheritance
{
    abstract class Person
    {
        protected string name;
        private readonly DateTime birthday;
        public Person()
        {
            name = "no name";
            birthday = new DateTime(2000, 5, 5);
        }
        public Person(string n, DateTime b)
        {
            name = n;
            if (b > DateTime.Now)
                birthday = new DateTime(2000, 5, 5);
            else
                birthday = b;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Name : {name}, Birthday : {birthday.ToShortDateString()}");

        }
        public abstract void DoWork();
        public override string ToString()
        {
            return $"Name : {name}, Birthday : {birthday.ToShortDateString()}";
        }
    }
    class Worker : Person
    {
        private double salary;

        public double Salary
        {
            get { return salary; }
            set { this.salary = value >= 0 ? value : 0; }
        }
        public Worker() : base()
        {
            Salary = 0;
        }
        public Worker(string n, DateTime b, double s) : base(n, b)
        {
            Salary = s;
        }
        public override void DoWork()
        {
            Console.WriteLine("Doing some work......");

        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Salary : {Salary}");
        }
    }
    sealed class Programmer : Worker
    {
        public int CodeLines { get; private set; }
        public Programmer() : base()
        {
            CodeLines = 0;
        }
        public Programmer(string n, DateTime b, double s) : base(n, b, s)
        {
            CodeLines = 0;
        }
        public sealed override void DoWork()
        {
            Console.WriteLine("Write code......");

        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Code lines : {CodeLines}");
        }
        public void WriteCode()
        {
            CodeLines++;
        }
    }
    class TeamLead : Worker
    {
        public int ProjectCount { get; set; }
        //public override void DoWork()
        //{
        //    Console.WriteLine("Manage team project");
        //}
    }

    abstract class Figure
    {
        public abstract int GetArea();
        public abstract int GetPerimeter();
    }
    class Triangle : Figure
    {
        public int A { get; set; }
        public int H { get; set; }
        public Triangle()
        {
            A = 0;
            H = 0;
        }
        public Triangle(int a, int h)
        {
            A = a;
            H = h;
        }
        public override int GetArea()
        {
            Console.WriteLine("Triangle : ");
            return A * H * 1 / 2;
        }
        public override int GetPerimeter()
        {
            Console.WriteLine("Triangle : ");
            return A * 3;
        }
    }
    class Square : Figure
    {
        public int A { get; set; }
        public Square()
        {
            A = 0;
        }
        public Square(int a)
        {
            A = a;
        }
        public override int GetArea()
        {
            Console.WriteLine("Square : ");
            return A * A;
        }
        public override int GetPerimeter()
        {
            Console.WriteLine("Square : ");
            return A * 4;
        }
    }
    class Romb : Figure
    {
        public int A { get; set; }
        public Romb()
        {
            A = 0;
        }
        public Romb(int a)
        {
            A = a;
        }
        public override int GetArea()
        {
            Console.WriteLine("Romb : ");
            return A * A;
        }
        public override int GetPerimeter()
        {
            Console.WriteLine("Romb : ");
            return A * 4;
        }
    }
    class Rectangle : Figure
    {
        public int A { get; set; }
        public int B { get; set; }
        public Rectangle()
        {
            A = 0;
            B = 0;
        }
        public Rectangle(int a, int b)
        {
            A = 0;
            B = 0;
        }
        public override int GetArea()
        {
            Console.WriteLine("Rectangle : ");
            return A * B;
        }
        public override int GetPerimeter()
        {
            Console.WriteLine("Rectangle : ");
            return A * B * 2;
        }
    }
    class Parallelogram : Figure
    {
        public int A { get; set; }
        public int B { get; set; }
        public int H { get; set; }
        public Parallelogram()
        {
            A = 0;
            B = 0;
            H = 0;
        }
        public Parallelogram(int a, int b, int h)
        {
            A = a;
            B = b;
            H = h;
        }
        public override int GetArea()
        {
            Console.WriteLine("Paralelogram : ");
            return A * H;
        }
        public override int GetPerimeter()
        {
            Console.WriteLine("Paralelogram : ");
            return A * B * 2;
        }
    }
    class Trapez : Figure
    {
        public int L { get; set; }
        public int H { get; set; }
        public Trapez(int l, int h)
        {
            L = l;
            H = h;
        }
        public override int GetArea()
        {
            Console.WriteLine("Trapeze : ");
            return L * H;
        }
        public override int GetPerimeter()
        {
            Console.WriteLine("Trapeze : ");
            return L * H * 2;
        }
    }
    class Kolo : Figure
    {
        public int P { get; set; }
        public int R { get; set; }
        public Kolo()
        {
            P = 0;
            R = 0;

        }
        public Kolo(int p, int r)
        {
            P = p;
            R = r;
        }
        public override int GetArea()
        {
            Console.WriteLine("Kolo: ");
            return P * R * R;
        }
        public override int GetPerimeter()
        {
            Console.WriteLine("Kolo: ");
            return R * P * 2;
        }
    }
    class Ellipse : Figure
    {
        public int P { get; set; }
        public int R { get; set; }
        public Ellipse()
        {
            P = 0;
            R = 0;

        }
        public Ellipse(int p, int r)
        {
            P = p;
            R = r;
        }
        public override int GetArea()
        {
            Console.WriteLine("Ellipse : ");
            return P * R * R;
        }
        public override int GetPerimeter()
        {
            Console.WriteLine("Ellipse : ");
            return R * P * 2;
        }
    }
    class CompasiteFigures
    {
        Figure[] figures;
        public CompasiteFigures(params Figure[] figures)
        {
            this.figures = figures;
        }
        public void ShowAll()
        {
            foreach (Figure item in figures)
            {
                Console.WriteLine(item.GetPerimeter());
                Console.WriteLine(item.GetArea());

            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CompasiteFigures figures = new CompasiteFigures
                (
                new Triangle(5, 2),
                new Kolo(3, 2),
                new Square(3),
                new Romb(4),
                new Rectangle(3, 2),
                new Parallelogram(2, 2, 2),
                new Trapez(2, 3),
                new Ellipse(3, 4)
                );
            figures.ShowAll();












            //Worker worker = new Worker("Vova", new DateTime(1995, 7, 8), 32000);
            //worker.Print();
            //Programmer programer = new Programmer("Ivan", new DateTime(2000, 12, 14), 45000);
            //programer.WriteCode();
            //programer.WriteCode();
            //programer.WriteCode();
            //programer.Print();
            //Person[] people = new Person[]
            //{
            //    //new Person(),
            //    worker,
            //    programer,
            //    new Worker("Petro", new DateTime(1997,3,5),15000)
            //};
            //Console.WriteLine();
            //Programmer pr = null;
            //try
            //{
            //    pr = (Programmer)people[2];
            //    pr.DoWork();
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}

            //pr = people[2] as Programmer;
            //if (pr != null)
            //{
            //    pr.DoWork();
            //}
            //else
            //    Console.WriteLine("null");

            //if (people[2] is Programmer)
            //{
            //    pr = people[2] as Programmer;
            //    pr.DoWork();
            //}
            //Console.WriteLine();
            //foreach (var item in people)
            //{
            //    Console.WriteLine("-----------Info--------");
            //    item.Print();
            //    Console.WriteLine();
            //}
        }
    }
}
