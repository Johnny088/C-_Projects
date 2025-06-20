namespace _05_StructRefOut
{
    internal class Program
    {
        class Worker
        {
            public string Name { get; private set; }
            public string Surname { get; private set; }
            private int age;

            public int Age
            {
                get { return age; }
                set 
                {
                    if (value < 18)
                    {
                        age = 18;
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
                        salary = 8000;
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





        }
        static void Main(string[] args)
        {
            
        }
    }
}
