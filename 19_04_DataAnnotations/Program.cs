using System.ComponentModel.DataAnnotations;
using System.Text.Json;
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
        [RegularExpression(@"\w{4,}\@\w{2,}\.\w{2,}", ErrorMessage = "Email is wrong")]
        public string Email { get; set; }
        [Required(ErrorMessage = "the login was not set up")]
        [RegularExpression(@"[A-Z][a-z]{2,}", ErrorMessage = "your Login is incorrect")]
        public string Login { get; set; }
        //[Required]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[^A-Za-z0-9]).{6,}$", ErrorMessage = "The password must have at least one Upper letter, one lower letter, " +
            "one number, one special symbol and length of the password must be 6 or more symbols ")]
        public string Password { get; set; }
        [Required]
        [Compare(nameof(Password), ErrorMessage = "Not confirm password")]
        public string ConfirmPassword { get; set; }
        [Phone]
        [RegularExpression(@"0\d{9,}", ErrorMessage = "template of the telephone 0687894515")]
        public string Phone { get; set; }

    }
    class UserData
    {
        Dictionary<int, User> users = new Dictionary<int, User>();
        public void add()
        {
            string usersJson = "users.json";     //variable with the name of the file
            string jsonString = "";              // AN empty string, Why? I have no Idea, but it works...

            User user = new User();
            bool isValid = true;                // why is it exactly true, why not false??? 
            do
            {
                Console.WriteLine("Enter name: ( minimum 2 characters)");
                string name = Console.ReadLine()!;

                Console.WriteLine("Enter age");
                int age = int.Parse(Console.ReadLine()!);

                Console.WriteLine("Enter Login   (First Letter is Upper then minimum 2 lower letters)");
                string login = Console.ReadLine()!;

                Console.WriteLine("Enter password");
                string password = Console.ReadLine()!;

                Console.WriteLine("Confirm password");
                string confirmPassword = Console.ReadLine()!;

                Console.WriteLine("Enter email");
                string email = Console.ReadLine()!;

                Console.WriteLine("Enter phone");
                string phone = Console.ReadLine()!;

                int temp = users.Count + 1;
                bool flag = true;
                while (flag)
                {
                    if(!users.ContainsKey(temp))
                    {
                        Console.WriteLine(temp);
                        user.Id = temp;
                        
                        flag = false;
                        
                    }
                    else
                    {
                        temp++;
                    }
                }
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
                    users.Add(temp, user);
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
        public void Show()
        {
            Program.printC("");
            foreach (var user in users)
            {
                Console.WriteLine($"ID: {user.Value.Id} \nName: {user.Value.Name} \nAge: {user.Value.Age} " +
                    $"\nEmail: {user.Value.Email} \nPhone: {user.Value.Phone} \nLogin: {user.Value.Login} \n----------------------------------------------------------------------");
            }
        }

    }

    internal class Program
    {
        static void Menu()
        {
            UserData users = new UserData();
            //users.read();      // read your file by itself during th launch the project.
            //int key;
            int choice;
            do
            {
                printDC("Main Menu");
                printY("1 - to add another user \n2 - to read all users from the file \n3 - write to the file \n4 - Delete an user by using Id \n5 - print users \n0 - exit");
                printC("");
                choice = int.Parse(Console.ReadLine()!);
                switch (choice)
                {
                    case 1:
                        users.add();
                        break;
                    case 2:
                        users.read();
                        break;
                    case 3:
                        users.update();
                        break;
                    case 4:
                        users.delete();
                        break;
                    case 5:
                        users.Show();
                        break;
                    case 0:
                        printC("Have a nice day");
                        break;
                    default:
                        break;
                }

            } while (choice != 0);



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
        public static void reset()
        {
            Console.ResetColor();
        }
        #endregion
        static void Main(string[] args)
        {

            Menu();
            reset();
        }
    }
}