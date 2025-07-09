using System.Threading.Channels;

namespace _15_Dictionary
{
    class Contact
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Contact(string name, string surname)
        {

            Name = name;
            Surname = surname;

        }
        public override string ToString()
        {
            return $"Name: {Name} Surname: {Surname}";
        }
        
    }
    class Phonebook
    {

        Dictionary<string, Contact> contact = new Dictionary<string, Contact>();
        public void add(string phone, Contact cont)
        {
            if(contact.ContainsKey(phone))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("error key");
                Console.ForegroundColor = ConsoleColor.Cyan;

            }
                
 
            else
                contact.Add(phone, cont);
        }
        public void print()
        {
            int count = 0;
            foreach (var item in contact)
            {
                count ++;
                Console.WriteLine($" the contact number {count}\n tel: {item.Key} name: {item.Value}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("task1. \nРеалізувати клас PhoneBook на базі дженерік колекції " +
                "\r\nDictionary<TKey, TValue>, " +
                "\r\nпередбачити додавання, зміну, пошук та видалення записів.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Phonebook phonebook = new Phonebook();
            
            phonebook.add("25", new Contact("John", "Stone"));
            
            phonebook.add("26", new Contact("Matthew", "Martin"));
           
            phonebook.add("26", new Contact("Rebeca", "Murthy"));
            phonebook.print();



            Console.ResetColor();
        }
    }
}
