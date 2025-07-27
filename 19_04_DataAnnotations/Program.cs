using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Transactions;
namespace _19_04_DataAnnotations
{
    class User                                        //CRUD - Create, Read, Update, Delete
    {
        [Required(ErrorMessage = "Id not defined")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name not setted")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Wrong lenght")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age not setted")]
        [Range(1, 125, ErrorMessage = "Wrong age")]
        public int Age { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare(nameof(Password), ErrorMessage = "Not confirm password")]
        public string ConfirmPassword { get; set; }
        [Phone]
        public string Phone { get; set; }

    }
    class UserData
    {
        Dictionary<int,User> users = new Dictionary<int, User>();
        public void add()
        {
            string usersJson = "users.json";     //variable with the name of the file
            string jsonString = "";              // AN empty string, Why? I have no Idea, but it works...

            User user = new User();
            bool isValid = true;                // why is it exactly true, why not false??? 
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


                user.Id = users.Count+1;
                user.Name = name;
                user.Age = age;
                user.Password = password;
                user.ConfirmPassword = confirmPassword;
                user.Email = email;
                user.Phone = phone;
                user.Login = login;




                var result = new List<ValidationResult>();
                var context = new ValidationContext(user);
                if (!(isValid = Validator.TryValidateObject(user, context, result, true)))
                {
                    foreach (ValidationResult error in result)
                    {
                        Console.WriteLine(error.MemberNames.FirstOrDefault() + ": " + error.ErrorMessage);
                    }
                }
                if (isValid)
                {
                    users.Add(users.Count + 1, user);
                    //jsonString = JsonSerializer.Serialize(user);  // creating the Json string into the memory
                    //File.WriteAllText(usersJson, jsonString);     // sending first the path to the file / then Json string
                }


            } while (!isValid);
        }
        public void read()
        {
            users = null;
            string jsonStream = File.ReadAllText("users.json");
            users = JsonSerializer.Deserialize<Dictionary<int, User>>(jsonStream)!; // you may need to create this file before
            Program.printG("The data was read from the file");
            
        }
        public void update()   //update how I understand it's about writing the data into the file, so I'll just do it.
        {
            
            string jsonStream = "users.json";
            string jsonData = JsonSerializer.Serialize(users);
            File.WriteAllText(jsonStream, jsonData);
        }
        public void delete()
        {
            Program.printY("Enter the id you wanna delete");
            int key = int.Parse(Console.ReadLine()!);
            if (users.ContainsKey(key))
            {
                Program.printR(users[key].Name + "was deleted");
                users.Remove(key);

            }
            else
            {
                Program.printG("This key doesn't exist");

            }
        }

    }

    internal class Program
    {
        static void Menu()
        {
            Console.WriteLine("Registration form");
            
        }
        #region print
        public static void printR<type>(type message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        public static void printC<type>(type message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
        }
        public static void printDC<type>(type message)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(message);
        }
        public static void printY<type>(type message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
        }
        public static void printG<type>(type message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
        public static void printDY<type>(type message)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(message);
        }
        #endregion
        static void Main(string[] args)
        {

            Menu();

            Console.WriteLine("Model is valid");
            //Menu();
        }
    }
}