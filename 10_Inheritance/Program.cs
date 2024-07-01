namespace _10_Inheritance
{
    //class Person
    //{
    //    protected string name;
    //    private readonly DateTime birthday;
    //    public Person()
    //    {
    //        name = "no name";
    //        birthday = new DateTime(2000, 5, 5);
    //    }
    //    public Person(string n, DateTime b)
    //    {
    //        name = n;
    //        if (b > DateTime.Now)
    //            birthday = new DateTime(2000, 5, 5);
    //        else
    //            birthday = b;
    //    }
    //    public virtual void Print()
    //    {
    //        Console.WriteLine($"Name : {name}, Birthday : {birthday.ToShortDateString()}");

    //    }
    //    public override string ToString()
    //    {
    //        return $"Name : {name}, Birthday : {birthday.ToShortDateString()}";
    //    }
    //}
    //class Worker : Person
    //{
    //    private double salary;

    //    public double Salary
    //    {
    //        get { return salary; }
    //        set { this.salary = value >= 0 ? value : 0; }
    //    }
    //    public Worker() : base()
    //    {
    //        Salary = 0;
    //    }
    //    public Worker(string n, DateTime b, double s) : base(n, b)
    //    {
    //        Salary = s;
    //    }
    //    public virtual void DoWork()
    //    {
    //        Console.WriteLine("Doing some work......");

    //    }
    //    public override void Print()
    //    {
    //        base.Print();
    //        Console.WriteLine($"Salary : {Salary}");
    //    }
    //}
    //sealed class Programmer : Worker
    //{
    //    public int CodeLines { get; private set; }
    //    public Programmer() : base()
    //    {
    //        CodeLines = 0;
    //    }
    //    public Programmer(string n, DateTime b, double s) : base(n, b, s)
    //    {
    //        CodeLines = 0;
    //    }
    //    public sealed override void DoWork()
    //    {
    //        Console.WriteLine("Write code......");

    //    }
    //    public override void Print()
    //    {
    //        base.Print();
    //        Console.WriteLine($"Code lines : {CodeLines}");
    //    }
    //    public void WriteCode()
    //    {
    //        CodeLines++;
    //    }
    //}
    //class TeamLead : Worker
    //{
    //    public int ProjectCount { get; set; }
    //    //public override void DoWork()
    //    //{
    //    //    Console.WriteLine("Manage team project");
    //    //}
    //}
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Worker worker = new Worker("Vova", new DateTime(1995, 7, 8), 32000);
            //worker.Print();
            //Programmer programer = new Programmer("Ivan", new DateTime(2000, 12, 14), 45000);
            //programer.WriteCode();
            //programer.WriteCode();
            //programer.WriteCode();
            //programer.Print();
            //Person[] people = new Person[]
            //{
            //    new Person(),
            //    worker,
            //    programer,
            //    new Worker("Petro", new DateTime(1997,3,5),15000)
            //};
            //Console.WriteLine();
            //Programmer pr = null;

            //pr = (Programmer)people[2];
            //pr.DoWork();

            //Console.WriteLine();
            //foreach (var item in people)
            //{
            //    Console.WriteLine("-----------Info--------");
            //    item.Print();
            //    Console.WriteLine();
//            }
//        }
//    }
//}
