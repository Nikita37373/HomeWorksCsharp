using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _13_Delegates
{

    //class MyDelegate : Delegate
    //{

    //}
    //public delegate void VoidDelegate();
    public delegate int IntDelegate(double value);

    public delegate void SetStringDelegate(string str);
    public delegate double DoubleDelegate();
    public delegate void VoidDelegate();

    class SuperClass
    {
        public void Print(string str)
        {
            Console.WriteLine(str);
        }
        public static double GetKoef()
        {
            double res = new Random().NextDouble();
            return res;
        }
        public double GetNum()
        {
            return new Random().Next(); ;
        }
        public void DoWork()
        {
            Console.WriteLine("I do some work.....");
        }
        public void Test()
        {
            Console.WriteLine("I testing.....");
        }
    }
    public delegate double CalculatorDelegate(double x, double y);
    class Calculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
        public double Sub(double x, double y)
        {
            return x - y;
        }
        public double Multy(double x, double y)
        {
            return x * y;
        }
        public double Div(double x, double y)
        {
            if (y != 0)
                return x / y;
            else
                throw new DivideByZeroException();
        }
    }
    public delegate int ChangeDelegate(int value);


    public delegate int DelegateCount();
    public delegate void DelegateZmina();
    class Calc
    {
        int[] arr;
        Random random = new Random();
        public Calc()
        {
            arr = null;
        }
        public Calc(int num)
        {
            arr = new int[num];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-50 , 50);
            }
        }
        public int CountNeg()
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    count++;
                }
            }
            return count;
        }
        public int Suma()
        {
            int suma = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                suma += arr[i];
            }
            return suma;
        }
        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
        public int CountSimpleNum()
        {
            int countSimpl = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrime(arr[i]))
                {
                    countSimpl++;
                }
                
            }
            return countSimpl;
        }
        public void SwitchTo0()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = 0;
                }
            }
            
        }
        public void Sooort()
        {
            Array.Sort(arr);
        }
        public void Sort2_0()
        {
            int[] arr1 = new int[arr.Length];
            int a = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {

                    arr1[a] = arr[i];
                    a++;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    arr1[a] = arr[i];
                    a++;
                }
            }
            
        }
        public void Print()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }


    public delegate void MenuDelegate();
    internal class Program
    {
        public static void DoOperation(double a, double b, CalculatorDelegate operation)
        {
            Console.WriteLine(operation.Invoke(a, b));
        }
        public static void ChangeElements(int[]arr , ChangeDelegate change)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = change.Invoke(arr[i]);
            }
        }
        static int Sqr(int v)
        {
            return v * v;
        }
        static int Increment(int v)
        {
            return ++v;
        }
        static int Decrement(int v)
        {
            return v++;
        }
        
        static void Menu1()
        {
            Calc calc = new Calc();
            DelegateCount[] menus = new DelegateCount[] { calc.CountNeg, calc.CountSimpleNum, calc.Suma };
            Console.WriteLine("1 - Count neg");
            Console.WriteLine("2 - Count simple num");
            Console.WriteLine("3 - Suma");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(menus[a - 1]);
        }
        static void Menu2()
        {
            Calc calc = new Calc();
            DelegateZmina[] menus = new DelegateZmina[] { calc.Sooort, calc.Sort2_0, calc.SwitchTo0 };
            Console.WriteLine("1 - Sort");
            Console.WriteLine("2 - First parni - last neparni");
            Console.WriteLine("3 - Swith to 0");
            int a = int.Parse(Console.ReadLine());
            menus[a - 1].Invoke();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1 - count");
            Console.WriteLine("2 - change");
            MenuDelegate[] menus = new MenuDelegate[] { Menu1 , Menu2};
            int a =int.Parse(Console.ReadLine());
            menus[a-1].Invoke();
            














            //int[] arr = new int[] { 1, 23, 4, 5, 7, 3, 2, 4, 4 };
            //foreach (var item in arr) Console.WriteLine(item + " ");Console.WriteLine();
            //ChangeElements(arr, Sqr);
            //foreach (var item in arr) Console.WriteLine(item + " ");Console.WriteLine();
            //ChangeElements(arr, Increment);
            //foreach (var item in arr) Console.WriteLine(item + " ");Console.WriteLine();
            //ChangeElements(arr, Decrement);
            //foreach (var item in arr) Console.WriteLine(item + " ");Console.WriteLine();
            //ChangeElements(arr, delegate(int v) { return v + 10;});
            //foreach (var item in arr) Console.WriteLine(item + " "); Console.WriteLine();


            //ChangeElements(arr, v =>  --v );
            //foreach (var item in arr) Console.WriteLine(item + " "); Console.WriteLine();




            //Calculator calculator = new Calculator();
            //DoOperation(125, 47, calculator.Add);
            //DoOperation(125, 47, calculator.Sub);
            //DoOperation(125, 47, calculator.Multy);
            //DoOperation(125, 47, calculator.Div);
            //CalculatorDelegate calcDelegate = null;
            //calcDelegate += calculator.Add;
            //calcDelegate += calculator.Sub;
            //calcDelegate += calculator.Multy;
            //calcDelegate += calculator.Div;
            //calcDelegate -= calculator.Div;

            //foreach (CalculatorDelegate i in calcDelegate.GetInvocationList())
            //{
            //    Console.WriteLine($"Res : {(i as CalculatorDelegate)!.Invoke(100, 25)}");

            //}

            //Calculator calculator = new Calculator();
            //double x, y;
            //int key;
            //do
            //{
            //    CalculatorDelegate calcDelegate = null;
            //    Console.WriteLine("Enter first number ");
            //    x = double.Parse(Console.ReadLine()!);
            //    Console.WriteLine("Enter second number ");
            //    y = double.Parse(Console.ReadLine()!);
            //    Console.WriteLine("Add  - 1 ");
            //    Console.WriteLine("Sub  - 2 ");
            //    Console.WriteLine("Mult  - 3 ");
            //    Console.WriteLine("Divide  - 4 ");
            //    Console.WriteLine("Exit  - 0 ");
            //    key = int.Parse(Console.ReadLine()!);
            //    switch (key)
            //    {
            //        case 1:
            //            calcDelegate = new CalculatorDelegate(calculator.Add);
            //            break;
            //        case 2:
            //            calcDelegate = new CalculatorDelegate(calculator.Sub);
            //            break;
            //        case 3:
            //            calcDelegate = calculator.Multy;
            //            break;
            //        case 4:
            //            calcDelegate = calculator.Div;
            //            break;
            //        case 0:
            //            Console.WriteLine("Good  Buy");
            //            break;
            //        default:
            //            Console.WriteLine("Error choice......");
            //            break;
            //    }

            //    Console.WriteLine("Res = " + calcDelegate?.Invoke(x, y));
            //} while (key != 0);





            //SuperClass superClass = new SuperClass();

            //DoubleDelegate method = null;

            //if (method == null)
            //    Console.WriteLine("method is null");
            //else
            //    Console.WriteLine(method());

            //Console.WriteLine(method?.Invoke());

            //DoubleDelegate[] arr = new DoubleDelegate[]
            //{
            //    SuperClass.GetKoef,
            //    superClass.GetNum

            //};
            //Console.WriteLine(arr[0].Invoke());
            //Console.WriteLine(arr[1]());

            //SetStringDelegate stringDelegate = new SetStringDelegate(superClass.Print);
            //VoidDelegate @void = new VoidDelegate(superClass.DoWork);
            //stringDelegate.Invoke("Hello mir");
            //@void.Invoke();

            //method += new DoubleDelegate(superClass.GetNum);
            //method += superClass.GetNum;
            //method += SuperClass.GetKoef;
            //foreach (var item in method.GetInvocationList())
            //{
            //    Console.WriteLine((item as DoubleDelegate)!.Invoke());
            //}
            //Console.WriteLine($"Last Method : {method.Invoke()}");



        }
    }
}
