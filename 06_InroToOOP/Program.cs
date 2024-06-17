namespace _06_InroToOOP
{


    class MyClass : Object
    {
        
        private int number;
        private string name;
        private const float pi = 3.14f;
        private readonly int id = 10;
        public MyClass()
        {
            id = 10;
        }
        public void Print()
        {
            Console.WriteLine($"Name : {name}. Id : {id}");

        }
        public override string ToString()
        {
            return $"Name : {name}. Id : {id}";
        }
    }
    class DerivedClass : MyClass
    {

    }
    struct MyStruct
    {
        public int x;
        public int y;
    }
    partial class Point
    {
        int xCoord;
        public int XCoord
        {
            get { return xCoord; }
            set
            {
                if (value > 0)
                    this.xCoord = value;
                else
                    this.xCoord = Math.Abs(value);
            }
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; }
        public string Color { get; private set; } = "White";

        private int yCoord;

        public int YCoord
        {
            get { return yCoord; }
            set
            {
                if (value >= 0)
                    yCoord = value;
                else
                    yCoord = Math.Abs(value);
            }
        }
   
        public void Print()
        {
            Console.WriteLine($"X : {xCoord} .Y : {yCoord}");

        }
        public override string ToString()
        {
            return $"X : {xCoord} .Y : {yCoord}";
        }
    }
    partial class Point
    {
        public void TestFunction()
        {
            Console.WriteLine("Test Function ");
        }
    }


    partial class Freezer
    {
        public string Color { get; set; }
        private int price;
        public int Price
        {
            get { return price; }
            set
            {
                if (price > 0)
                    price = value;
                else
                    price = Math.Abs(value);
            }
        }
        public string Type { get; set; }
        public string Brend { get; set; }
        private int area;
        public int Area
        {
            get { return area; }
            set
            {
                if (area > 0)
                    area = value;
                else
                    area = Math.Abs(value);
            }
        }


        static int count;
        static string count1;
        

    }




    internal class Program
    {
        static void Main(string[] args)
        {
            //MyClass myClass = new MyClass();
            //myClass.Print();
            //Console.WriteLine(myClass.ToString());

            //Point p = new Point(-8,-12);
            //p.Print();
            //Console.WriteLine(p);
            //p.SetX(100);
            //p.SetY(2121);

            //p.XCoord = 222;
            //int x = p.XCoord;
            //Console.WriteLine(x);
            //Console.WriteLine(p.XCoord);
            //p.Name = "2D_Point";
            //Console.WriteLine(p.Name);

            Freezer[] frezers = new Freezer[5]
            {
                new Freezer()
                {
                     Color = "white",
                     Price = 5000,
                     Type = "Holodos",
                     Brend = "Samsung",
                     Area = 999

                },
                 new Freezer()
                {
                     Color = "red",
                     Price = 2000,
                     Type = "Holodos",
                     Brend = "LG",
                     Area = 9999

                },
                  new Freezer()
                {
                     Color = "Blue",
                     Price = 5555,
                     Type = "Holodos",
                     Brend = "Samsung",
                     Area = 222

                },
                   new Freezer()
                {
                     Color = "Green",
                     Price = 5050,
                     Type = "Holodos",
                     Brend = "Samsung",
                     Area = 777

                },
                    new Freezer()
                {
                     Color = "Yellow",
                     Price = 10000,
                     Type = "Holodos",
                     Brend = "Samsung",
                     Area =2222

                }

            };
            foreach (Freezer item in frezers)
            {
                Console.WriteLine(item);
            }







        }
    }
}
