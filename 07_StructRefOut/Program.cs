using System.Data.Common;

namespace _07_StructRefOut
{
    partial struct MyStruct
    {
        public int MyProperty { get; set; }
    }
    partial struct MyStruct
    {
        public int MyProperty1 { get; set; }
    }
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    
    internal class Program
    {
        static void MethosWithParams(string name ,params int[]marks)
        {
            Console.WriteLine("----------------" + name + "---------------");
            foreach (var item in marks)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] marks = new int[] { 11, 12, 7, 5, 3, 3, 12, 10 };
            MethosWithParams("Bob", marks);
            MethosWithParams("Tom", new int[] {11,12,4,6,9,11});
            MethosWithParams("Ivanko", 11,12,4,6,9,11);


            //Point p = new Point();

            //_3D_Object.Point point = new _3D_Object.Point();

        }
    }
}

namespace _3D_Object
{
    struct Point
    { 
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
    }

}



