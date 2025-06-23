namespace _05_StructRefOut
{
    internal class Program
    {
        class Worker
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            private int age;

            public int Age
            {
                get { return age; }
                set 
                {
                    if (value < 18)
                    {
                        throw new Exception(" Age is not common ");
                    }
                    else
                    {
                        age = value;
                    }
                }
            }
            private double salary;

            public double Salary
            {
                get { return salary; }
                set 
                {
                    if (value < 8000)
                    {
                        throw new Exception("Your Salary is less then minimum in your country");
                    }
                    else
                    {
                        salary = value;
                    }
                }
            }
            private DateTime employmentStartData;

            public DateTime EmploymentStartData
            {
                get { return employmentStartData; }
                set 
                {
                    if(value < DateTime.Now)
                    {
                        employmentStartData = value;
                    }
                    else
                    {
                        throw new Exception("Wrong date of employment");
                    }
                }
            }
            public Worker()
            {
             
            }
            public Worker(string name, string surname,int age,double salary, DateTime employmentStartData)
            {
                Name = name;
                Surname = surname;
                Age = age;
                Salary = salary;
                EmploymentStartData = employmentStartData;
            }
            public void print()
            {
                Console.WriteLine($"Name: {Name} \nSurname: {Surname} \n age: {age} \nSalary: {salary} \nEmployment start date: {EmploymentStartData} \nExperience: {(DateTime.Now - EmploymentStartData).TotalDays}");
            }
            
        }

        static void MainMenu1()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            int key;
            int size;
            Worker[] workers = null;
            do
            {
                
                Console.WriteLine("1 - Making an array of workers. \n2 - Showing all workers \n3 - Exit");
                key = int.Parse(Console.ReadLine()!);
                string name;
                string surname;
                int age;
                double salary;
                int year;
                int month;
                int day;
                switch (key)
                {
                    case 1:
                        Console.Write ("How many workers do you wanna add? ");
                        size = int.Parse(Console.ReadLine()!);
                        Console.WriteLine();
                        workers = new Worker[size];
                        try
                        {
                            for (int i = 0; i < workers.Length; i++)
                            {
                                workers[i] = new Worker();
                                Console.Write("Enter the name: "); workers[i].Name = Console.ReadLine()!; Console.WriteLine();
                                Console.Write("Enter the surname: "); workers[i].Surname = Console.ReadLine()!; Console.WriteLine();
                                Console.Write("Enter the age: "); workers[i].Age = int.Parse(Console.ReadLine()!); Console.WriteLine();
                                Console.Write("Enter the Salary of employment: "); workers[i].Salary = double.Parse(Console.ReadLine()!); Console.WriteLine();
                                Console.Write("Enter day of employment: "); workers[i].EmploymentStartData = Convert.ToDateTime (Console.ReadLine()!); Console.WriteLine();
                                //Console.Write("Enter the year of employment: "); year = int.Parse(Console.ReadLine()!); Console.WriteLine();
                                //Console.Write("Enter the month of employment: "); month = int.Parse(Console.ReadLine()!); Console.WriteLine();
                                //Console.Write("Enter the day of employment: "); day = int.Parse(Console.ReadLine()!); Console.WriteLine();
                                //workers[i] = new Worker(name, surname, age, salary, new DateTime(year, month, day));

                            }
                        }
                        catch (Exception e) { Console.WriteLine(e.Message); }
                        
                        break;
                    case 2:
                        foreach (var item in workers)
                        {
                            item.print();
                        }
                        break;
                    default:
                        break;
                }
                
            } while (key != 0);

        }
        static void Main(string[] args)
        {
            Console.WriteLine();
            MainMenu1();
            Worker worker = new Worker("name","surname", 30, 59000000, new DateTime (2000,12,13)); // input from keyboard year-month-day
            ////worker.EmploymentStartData.Date = DateTime.
            
        }
    }
}
