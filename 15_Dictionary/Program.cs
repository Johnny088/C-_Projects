//using System.Threading.Channels;

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
            return $"Person: {Name,10} {Surname,10}";
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
        public void edit(string phone, Contact cont)
        {
            if(contact.ContainsKey(phone))
            {
                
               
                contact[phone] = cont;
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("error key");
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
        }
        public void search(string phone)
        {
            if (contact.ContainsKey(phone))
            {
                Console.WriteLine($" the contact number \n tel: {phone} person: {contact[phone].Name} {contact[phone].Surname}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("error key");
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
        }
        public void remove(string phone)
        {
            if (contact.ContainsKey(phone))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"The person: {phone} {contact[phone].Name} {contact[phone].Surname} was removed");
                Console.ForegroundColor = ConsoleColor.Cyan;
                contact.Remove(phone);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("error key");
                Console.ForegroundColor = ConsoleColor.Cyan;
            }

        }
        public void print()
        {
            int count = 0;
            foreach (var item in contact)
            {
                count ++;
                Console.WriteLine($" the contact {count}\n tel: {item.Key,-10} {item.Value}");
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
            phonebook.add("27", new Contact("Rebert", "Kiyosaki"));
            phonebook.add("28", new Contact("Brian", "Tracy"));
            phonebook.add("29", new Contact("Warren", "Buffet"));
            phonebook.print();
            phonebook.search("25");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("---------------------- Edit-------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            phonebook.edit("25", new Contact("Rebeca", "Murthy"));
            phonebook.print();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("---------------------- search-------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            phonebook.search("25");
            Console.WriteLine("---------------------------remove---------------------------------");
            phonebook.remove("25");
            phonebook.print();




            Dictionary<string, string> contacts = new Dictionary<string, string>();
            contacts.TryAdd("one", "two");
            contacts.TryAdd("one", "two");
            contacts.TryAdd("one", "two");
            if(!contacts.TryAdd("two","one"))
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("Error");
                Console.ForegroundColor= ConsoleColor.Cyan;
            }
            foreach (KeyValuePair<string,string> item in contacts)
            {
                Console.WriteLine($"Key : {item.Key} value: {item.Value}");
            }
            Console.WriteLine("========================================");
            foreach (var item in contacts)
            {
                Console.WriteLine($"Key : {item.Key} value: {item.Value}");
            }








                Console.ResetColor();
        }
    }
}
