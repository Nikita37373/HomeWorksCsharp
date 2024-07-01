using System.Collections;
using System.Diagnostics.Metrics;
using System.Runtime.Versioning;
using System.Xml.Schema;

namespace _12_StandartInterfaces
{
    class StudentCard: ICloneable
    {
        public int Number { get; set; }
        public string Series { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Name : {Number}. Series : {Series}";
        }
    }
    class Student: IComparable<Student>, ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday{ get; set; }
        public StudentCard StudentCard { get; set; }

        public object Clone()
        {
            Student copy = (this.MemberwiseClone() as Student)!;
            copy.StudentCard =(StudentCard) this.StudentCard.Clone();
            return copy;
        }

        public int CompareTo(Student? other)
        {
            return this.FirstName.CompareTo(other.FirstName); 
        }
        
        public override string ToString()
        {
            return $"Name : {FirstName} {LastName} . Birthday : {Birthday.ToShortDateString()}\n Student card: {StudentCard} ";
        }

    }
    class LastNameCompare : IComparer<Student>
    {
        //public int Compare(object? x, object? y)
        //{
        //    if (x is Student && y is Student)
        //    {
        //        return (x as Student).LastName.CompareTo((y as Student).LastName);

        //    }
        //}
        public int Compare(Student? x, Student? y)
        {
            return x!.LastName.CompareTo(y!.LastName);
        }
    }
    class BirthdayCompare : IComparer<Student>
    {
        
        public int Compare(Student? x, Student? y)
        {
            return x!.Birthday.CompareTo(y!.Birthday);
        }
    }
    class Auditory : IEnumerable
    {
        Student[] students;
        public Auditory()
        {
            students = new Student[]//Array
           {

                new Student
                {
                    FirstName = "Bill",
                    LastName = "Tomson",
                    Birthday = new DateTime(2005, 4, 7),
                    StudentCard = new StudentCard() { Number = 123456, Series = "AA" }
                },
                new Student
                {
                    FirstName = new string("Olga"),
                    LastName = "Ivanchuk",
                    Birthday = new DateTime(2003, 10, 17),
                    StudentCard = new StudentCard() { Number = 321456, Series = "BA" }
                },
                new Student
                {
                    FirstName = "Candice",
                    LastName = "Leman",
                    Birthday = new DateTime(2006, 3, 12),
                    StudentCard = new StudentCard() { Number = 7412585, Series = "AA" }
                },
                new Student
                {
                    FirstName = "Nicol",
                    LastName = "Taylor",
                    Birthday = new DateTime(2004, 7, 14),
                    StudentCard = new StudentCard() { Number = 963258, Series = "BK" }
                }
           };

        }

        public IEnumerator GetEnumerator()
        {
            return students.GetEnumerator();
        }
        public void Sort()
        {
            Array.Sort(students);
        }
        public void Sort(IComparer<Student> comparer)
        {
            Array.Sort(students , comparer);
        }
    }

    class Director: ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Director()
        {
            FirstName = "noname";
            LastName = "noname";
        }
        public Director(string fname, string lname)
        {
            LastName = lname;
            FirstName = fname;
        }
        public override string ToString()
        {
            return $"Name : {FirstName} {LastName} ";
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
    enum Genre { Comedy , Horror, Adventure , Drama , Boevik}
    class Movie : ICloneable , IComparable<Movie>
    {
        public string Title { get; set; }
        public Director Director { get; set; }
        public string Country { get; set; }
        public Genre Genre { get; set; }
        public int Year { get; set; }
        public short Rating { get; set; }
        public Movie()
        {
            Title = "no title";
            Director = new Director();
            Country = "no country";
            Genre = Genre.Comedy;
            Year = 2000;
            Rating = 1;
        }
        public Movie(string title ,string fname, string lname,string country, Genre genre, int year, short rating )
        {
            Title = title;
            Director = new Director(fname , lname);
            Country = country;
            Genre = genre;
            Year = year;
            Rating = rating;
        }
        public override string ToString()
        {
            return $"Title : {Title}, Director : {Director}, Country : {Country}, Genre : {Genre}, Year : {Year}, Rating : {Rating}";
        }
        public object Clone()
        {
            
            Movie copy = (this.MemberwiseClone() as Movie);
            copy.Director = (Director)this.Director.Clone();
            return copy;
        }
        public int CompareTo(Movie? other)
        {
            
            return this.Title.CompareTo(other.Title);
        }
    }
    class CompareByRating : IComparer<Movie>
    {
        public int Compare(Movie? x, Movie? y)
        {
            return x.Rating.CompareTo(y.Rating);
        }
    }
    class CompareByYear : IComparer<Movie>
    {
        public int Compare(Movie? x, Movie? y)
        {
            return x.Year.CompareTo(y.Year);
        }
    }
    class Cinema: IEnumerable
    {
        Movie[] movies;
        public string Address { get; set; }
        public Cinema()
        {
            Address = "no address";
            movies = null;
        }
        public Cinema(string addr )
        {
            Address = addr;
            movies = new Movie[]
            {
                new Movie
                {
                    Title = "Titanik",
                    Director = new Director("Viliam", "Perri"),
                    Country = "England",
                    Genre = Genre.Adventure,
                    Year = 1912,
                    Rating = 5
                },
                new Movie
                {
                    Title = "Titanik1",
                    Director = new Director("Viliam1", "Perri1"),
                    Country = "England1",
                    Genre = Genre.Adventure,
                    Year = 1913,
                    Rating = 2
                },
                new Movie
                {
                    Title = "Titanik2",
                    Director = new Director("Viliam2", "Perri2"),
                    Country = "England2",
                    Genre = Genre.Adventure,
                    Year = 1914,
                    Rating = 4
                },

            };
        }
        public void Sort()
        {
            Array.Sort(movies);
        }
        public void Sort(IComparer<Movie> comparer)
        {
            Array.Sort(movies, comparer);
        }

        public IEnumerator GetEnumerator()
        {
            return movies.GetEnumerator();
        }
    }








    internal class Program
    {
        static void Main(string[] args)
        {
            Cinema cinema = new Cinema("Coborna 16");
            foreach (var item in cinema)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------- Sort by Title -------------");
            cinema.Sort();
            foreach (var item in cinema)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------- Sort by Rating -------------");
            cinema.Sort(new CompareByRating());
            foreach (var item in cinema)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------- Sort by Year -------------");
            cinema.Sort(new CompareByYear());
            foreach (var item in cinema)
            {
                Console.WriteLine(item);
            }











            //Student student = new Student
            //{
            //    FirstName = "Bill",
            //    LastName = "Tomson",
            //    Birthday = new DateTime(2005, 4, 7),
            //    StudentCard = new StudentCard() { Number = 123456, Series = "AA" }
            //};
            //Console.WriteLine(student);
            //Student clone = (Student) student.Clone();
            //Console.WriteLine(clone);

            //clone.FirstName = "Tomas";
            //clone.Birthday = new DateTime(1992, 4, 2);
            //clone.StudentCard.Number = 99999;
            //Console.WriteLine(student);

            //Console.WriteLine(clone);

            //Auditory auditory = new Auditory();
            //foreach (var student in auditory) 
            //{
            //    Console.WriteLine(student);
            //    Console.WriteLine();
            //}
            //Console.WriteLine("---------------- Sort by name -------------");
            //auditory.Sort(); 
            //foreach (var student in auditory)
            //{
            //    Console.WriteLine(student);
            //    Console.WriteLine();
            //}
            //Console.WriteLine("---------------- Sort by Lastname -------------");
            //auditory.Sort(new LastNameCompare());
            //foreach (var student in auditory)
            //{
            //    Console.WriteLine(student);
            //    Console.WriteLine();
            //}
            //Console.WriteLine("---------------- Sort by Birthday -------------");
            //auditory.Sort(new BirthdayCompare());
            //foreach (var student in auditory)
            //{
            //    Console.WriteLine(student);
            //    Console.WriteLine();
            //}
        }
    }
}
