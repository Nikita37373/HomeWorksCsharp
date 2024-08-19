using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace _22_DataAnnotations
{
    class User 
    {


        public string ReceiverMail { get; set; }
        [Required(ErrorMessage = "Id not setted")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name not setted")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Illegal lenght")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Age not setted")]
        [Range(1, 120, ErrorMessage = "Age is incorrect")]
        public int Age { get; set; }
        [Phone]
        [RegularExpression(@"^([+][0-9]{10})$")]
        public string Phone { get; set; }
        [EmailAddress]
        [RegularExpression(@"^([A-Za-z0-9][^'!&\\#*$%^?<>()+=:;`~\[\]{}|/,₹€@ ][a-zA-z0- 9-._][^!&\\#*$%^?<>()+=:;`~\[\]{}|/,₹€@ ]*\@[a-zA-Z0-9][^!&@\\#*$%^?<> ()+=':;~`.\[\]{}|/,₹€ ]*\.[a-zA-Z]{2,6})$", ErrorMessage = "Please enter a valid Email")]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^([A-Za-z]")]
        public string Login { get; set; }
        [Required]
        [RegularExpression(@"^([A-Za-z]")]
        [Range(8, 24, ErrorMessage = "Must be >8")]
        public string Password { get; set; }
        [Required]
        [RegularExpression(@"^([A-Za-z])$")]
        [Range(8, 24, ErrorMessage = "Must be >8")]
        [Compare(nameof(Password), ErrorMessage = "not confirm password")]
        public string ConfirmPassword { get; set; }
    }
    



    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            bool isValid = true;
            do
            {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine()!;

                Console.WriteLine("Enter age");
                int age = int.Parse(Console.ReadLine()!);

                Console.WriteLine("Enter Login");
                string login = Console.ReadLine()!;

                Console.WriteLine("Enter password");
                string password = Console.ReadLine()!;

                Console.WriteLine("Confirm password");
                string confirmPassword = Console.ReadLine()!;

                Console.WriteLine("Enter email");
                string email = Console.ReadLine()!;

                Console.WriteLine("Enter phone");
                string phone = Console.ReadLine()!;

                user.Id = 1;
                user.Name = name;
                user.Age = age;
                user.Password = password;
                user.ConfirmPassword = confirmPassword;
                user.Email = email;
                user.Phone = phone;
                user.Login = login;

                var result = new List<ValidationResult>();
                var contex = new ValidationContext(user);
                if (!(isValid = Validator.TryValidateObject(user, contex, result, true)))
                {
                    foreach (ValidationResult error in result)
                    {
                        Console.WriteLine(error.MemberNames.FirstOrDefault() + ": " + error.ErrorMessage);
                    }
                }


            } while (!isValid);

            Console.WriteLine("Model is valid");
        }
    }
}
