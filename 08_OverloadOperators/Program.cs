using System.Drawing;

namespace _08_OverloadOperators
{
    class Point_3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point_3D() : this(0, 0,0) { }
        public Point_3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return $"X : {X}. Y :{Y} , z= {Z}";
        }

    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(): this(0, 0) { }
        public Point(int x , int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"X : {X}. Y :{Y} ";
        }

        public override bool Equals(object? obj)
        {
            return obj is Point point &&
                   X == point.X &&
                   Y == point.Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        #region Унарні оператори
        public static Point operator -(Point p)
        {
            Point res = new Point()
            {
                X = p.X * -1,
                Y = p.Y * -1
            };
            return res ;
        }
        public static Point operator ++ (Point p)
        {
            p.X++;
            p.Y++;
            return p;
        }
        public static Point operator --(Point p)
        {
            p.X--;
            p.Y--;
            return p;
        }
        #endregion
        #region Бінарні оператори
        public static Point operator +(Point p1 , Point p2)
        {
            Point res = new Point()
            {
                X = p1.X + p2.X,
                Y = p1.Y + p2.Y
            };
            return res;
        }
        public static Point operator -(Point p1, Point p2)
        {
            Point res = new Point()
            {
                X = p1.X - p2.X,
                Y = p1.Y - p2.Y
            };
            return res;
        }
        public static Point operator*(Point p1, Point p2)
        {
            Point res = new Point()
            {
                X = p1.X * p2.X,
                Y = p1.Y * p2.Y
            };
            return res;
        }
        public static Point operator /(Point p1, Point p2)
        {
            Point res = new Point()
            {
                X = p1.X / p2.X,
                Y = p1.Y / p2.Y
            };
            return res;
        }
        #endregion
        #region Порівняльні оператори
        public static bool operator ==(Point p1, Point p2)
        {
            return p1.Equals(p2);
        }
        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }
        #endregion
        #region ще одні порівняльні оператори
        public static bool operator > (Point p1 , Point p2)
        {
            return p1.X + p1.Y > p2.X + p2.Y;
        }
        public static bool operator <(Point p1, Point p2)
        {
            return !(p1> p2);
        }
        public static bool operator >=(Point p1, Point p2)
        {
            return p1.X + p1.Y >= p2.X + p2.Y;
        }
        public static bool operator <=(Point p1, Point p2)
        {
            return !(p1 >= p2);
        }
        #endregion
        #region true/false
        public static bool operator true(Point p)
        {
            return p.X >= 0 && p.Y >= 0;
        }
        public static bool operator false(Point p)
        {
            return p.X < 0 || p.Y < 0;
        }
        #endregion
        #region оператори перетворенняя типів
        public static explicit operator int(Point p)
        {
            return p.X + p.Y;
        }
        public static implicit operator double(Point p)
        {
            return p.X + p.Y;
        }
        public static implicit operator Point_3D(Point p)
        {
            return new Point_3D(p.X, p.Y, 55);
        }
        #endregion

    }
    class Square
    {
        public int A { get; set; }
        public Square() : this(0) { }
        public Square(int a)
        {
            A = a;
        }
        public override string ToString()
        {
            return $"A = {A}";
        }
        public override bool Equals(object? obj)
        {
            return obj is Square square &&
                   A == square.A;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(A);
        }
        public static Square operator ++(Square sq)
        {
            sq.A++;
            return sq;
        }
        public static Square operator --(Square sq)
        {
            sq.A--;
            return sq;
        }
        public static Square operator +(Square sq, Square sq2)
        {
            Square res = new Square();
            {
                res.A = sq.A + sq2.A;
                return res;
            }
        }
        public static Square operator -(Square sq, Square sq2)
        {
            Square res = new Square();
            {
                res.A = sq.A - sq2.A;
                return res;
            }
        }
        public static Square operator *(Square sq, Square sq2)
        {
            Square res = new Square();
            {
                res.A = sq.A * sq2.A;
                return res;
            }
        }
        public static Square operator /(Square sq, Square sq2)
        {
            Square res = new Square();
            {
                res.A = sq.A / sq2.A;
                return res;
            }
        }
        public static bool operator ==(Square sq, Square sq2)
        {
            return sq.Equals(sq2);
        }
        public static bool operator !=(Square sq, Square sq2)
        {
            return !(sq == sq2);
        }
        public static bool operator >(Square sq, Square sq2)
        {
            return sq.A > sq2.A;
        }
        public static bool operator <(Square sq, Square sq2)
        {
            return !(sq > sq2);
        }
        public static bool operator >=(Square sq, Square sq2)
        {
            return sq.A >= sq2.A;
        }
        public static bool operator <=(Square sq, Square sq2)
        {
            return !(sq >= sq2);
        }
        public static bool operator true(Square sq)
        {
            return sq.A >= 0;
        }
        public static bool operator false(Square sq)
        {
            return sq.A < 0;
        }

        public static implicit operator Rectangle(Square sq)
        {
            Rectangle r = new Rectangle();
            r.A = sq.A;
            r.B = sq.A;
            return r ;
        }
        public static implicit operator int(Square sq)
        {
            
            
            return sq.A * sq.A;
        }

    }
    class Rectangle
    {
        public int A { get; set; }
        public int B { get; set; }
        public Rectangle() : this(0,0) { }
        public Rectangle(int a, int b)
        {
            A = a;
            B = b;
        }
        public override string ToString()
        {
            return $"A = {A}, B = {B}";
        }
        public override bool Equals(object? obj)
        {
            return obj is Rectangle rectangle &&
                   A == rectangle.A &&
                   B == rectangle.B;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(A, B);
        }

        public static Rectangle operator ++(Rectangle rec)
        {
            rec.A++;
            rec.B++;
            return rec;
        }
        public static Rectangle operator --(Rectangle rec)
        {
            rec.A--;
            rec.B--;
            return rec;
        }
        public static Rectangle operator +(Rectangle rec, Rectangle rec2)
        {
            Rectangle res = new Rectangle();
            {
                res.A = rec.A + rec2.A;
                res.B = rec.B + rec2.B;
                return res;
            }
        }
        public static Rectangle operator -(Rectangle rec, Rectangle rec2)
        {
            Rectangle res = new Rectangle();
            {
                res.A = rec.A - rec2.A;
                res.B = rec.B - rec2.B;
                return res;
            }
        }
        public static Rectangle operator *(Rectangle rec, Rectangle rec2)
        {
            Rectangle res = new Rectangle();
            {
                res.A = rec.A * rec2.A;
                res.B = rec.B * rec2.B;
                return res;
            }
        }
        public static Rectangle operator /(Rectangle rec, Rectangle rec2)
        {
            Rectangle res = new Rectangle();
            {
                res.A = rec.A / rec2.A;
                res.B = rec.B / rec2.B;
                return res;
            }
        }
        public static bool operator ==(Rectangle rec, Rectangle rec2)
        {
            return rec.Equals(rec2);
        }
        public static bool operator !=(Rectangle rec, Rectangle rec2)
        {
            return !(rec == rec2);
        }
        public static bool operator >(Rectangle rec, Rectangle rec2)
        {
            return rec.A > rec2.A && rec.B > rec2.B;
        }
        public static bool operator <(Rectangle rec, Rectangle rec2)
        {
            return !(rec > rec2);
        }
        public static bool operator >=(Rectangle rec, Rectangle rec2)
        {
            return rec.A >= rec2.A && rec.B >= rec2.B;
        }
        public static bool operator <=(Rectangle rec, Rectangle rec2)
        {
            return !(rec >= rec2);
        }
        public static bool operator true(Rectangle rec)
        {
            return rec.A >= 0 && rec.B >= 0;
        }
        public static bool operator false(Rectangle rec)
        {
            return rec.A < 0 || rec.B < 0;
        }

        public static explicit operator Square(Rectangle rec)
        {
            Square res = new Square();
            res.A = rec.A + rec.B;
            return res;
        }
        public static explicit operator int(Rectangle rec)
        {
            
            
            return rec.A + rec.B;
        }

    }






    internal class Program
    {
        static void Main(string[] args)
        {











            //int a = 5;
            //Point pointt = new Point(7, 8);
            //a = (int)pointt;
            //Point_3D _3D = pointt;
            //Console.WriteLine(_3D);

            //string str = "Hello";
            //string str2 = "Hello";
            //if (str.Equals(str2))
            //{
            //    Console.WriteLine("Equals");
            //}
            //else
            //{
            //    Console.WriteLine("not Equals");
            //}





            //Point p = new Point(8,9);
            //Point p2 = new Point(2,4);
            //if (p > p2)
            //{
            //    Console.WriteLine("p1 > p2");
            //}
            //else
            //{
            //    Console.WriteLine("not equals");
            //}

            //if (p) Console.WriteLine("true");
            //else Console.WriteLine("false");



            //Console.WriteLine($"Point : {p}");
            //Console.WriteLine($"Point ++ : {p++}");
            //Console.WriteLine($"Point ++ : {++p}");
            //Console.WriteLine($"Point -- : {p--}");
            //Console.WriteLine($"Point -- : {--p}");

            //Point res = -p;
            //Console.WriteLine($"Res - : {res}");

            //Console.WriteLine($"Point : {p}");
            //Console.WriteLine($"Point2 : {p2}");
            //res = p + p2;
            //Console.WriteLine($"Res + : {res}");
            //res = p - p2;
            //Console.WriteLine($"Res - : {res}");
            //res = p * p2;
            //Console.WriteLine($"Res * : {res}");
            //res = p / p2;
            //Console.WriteLine($"Res / : {res}");

        }
    }
}
