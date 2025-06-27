

namespace _06_ExceptionNamespaces
{
    class CreditCard
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        private long cardNumber;

        public long CardNumber
        {
            get { return cardNumber; }
            set
            {
                if (value.ToString().Length == 16)
                {
                    cardNumber = value;
                   
                    //catch (FormatException e) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(e.Message); }
                }
                else if (value.ToString().Length > 16)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception ("Given too many characters");
                    
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception ("Given less numbers than the card exactly has."); 

                }
            }
        }
        public void print()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"name: {Name} \nsurname: {Surname} \nNumber: ");
            string temp = CardNumber.ToString();
            for (int i = 0; i < temp.Length; i++)
            {
                if ((i+1)%4 ==0)
                {
                    Console.Write (temp[i] + " ");
                }
                else
                {
                    Console.Write (temp[i]);
                }
               
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;


        }
        public CreditCard(string name, string surname, long number)
        {
            this.Name = name;
            this.Surname = surname;
            this.CardNumber = number;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int number2 = 0;
            int number1 = 0;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Task1. \nКористувач вводить до рядка з клавіатури набір сим-" +
                "\r\nволів від 0-9. Необхідно перетворити рядок на число ціло-" +
                "\r\nго типу. Передбачити випадок виходу за межі діапазону," +
                "\r\nякий визначається типом int. Використовуйте механізм" +
                "\r\nвиключень.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter the numbers: ");
            try
            {
                number1 = int.Parse(Console.ReadLine()!);
                //number2 = number1;
            }
            
            catch (FormatException e) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(e.Message); }
            catch (OverflowException e) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(e.Message); }
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (number1 !=0)
            {
                Console.WriteLine(number1);
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            //------------------------------------------------------------------------------------------------------------------------------------------------

            Console.WriteLine("Task2. \nСтворіть клас «Кредитна картка». Вам необхідно зберіга-" +
                "\r\nти інформацію про номер картки, ПІБ власника, CVC, дату" +
                "\r\nзавершення роботи картки і т.д. Передбачити механізми" +
                "\r\nініціалізації полів класу. Якщо значення для ініціалізації" +
                "\r\nнеправильне, генеруйте виняток.");
            Console.ForegroundColor= ConsoleColor.Cyan;
            long test_number = 0;
            Console.Write("Enter the name: "); string name = Console.ReadLine()!;
            Console.Write("Enter the surname: "); string surname = Console.ReadLine()!;
            Console.Write("Enter the number of the card: ");
            try 
            {
                test_number = long.Parse(Console.ReadLine()!);
            }
            catch (FormatException e) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(e.Message); Console.ForegroundColor = ConsoleColor.Cyan; }
            catch (OverflowException e) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(e.Message); Console.ForegroundColor = ConsoleColor.Cyan; }

            try
            {
                CreditCard card = new CreditCard(name, surname, test_number);
                card.print();
            }
            catch (Exception e) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(e.Message); }
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            //--------------------------------------------------------------------------------------------------------------------------------------------------

            Console.WriteLine("Task3 \nКористувач вводить до рядка з клавіатури математич-" +
                "\r\nний вираз. Наприклад, 3*2*1*4. Програма має підрахувати" +
                "\r\nрезультат введеного виразу. У рядку можуть бути лише" +
                "\r\nцілі числа і оператор*. Для обробки помилок введення" +
                "\r\nвикористовуйте механізм виключень.");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Type numbers separated by '*' for example 1*2*3*5*4: "); string temp = Console.ReadLine()!;
            String[] temp2 = temp.Split('*');
            foreach (String i in temp2)
            {
                Console.WriteLine(i);
            }
            long[] numbers = null;
            numbers = new long[temp2.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                try
                {
                    numbers[i] = long.Parse(temp2[i]);
                }
                catch (Exception) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Format is wrong"); }
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            long result = 1;
            Console.WriteLine("--------------------------------------------------------------");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
                
                result *= numbers[i]; 
            }
            Console.WriteLine($"Multiply is {result}");
        }
    }
}
