// See https://aka.ms/new-console-template for more information




using Lab3.Classes;

namespace Lab3 
{
    internal class Program {
        static void Main(string[] args) {
            List<Phone> phoneList = new List<Phone>();
            phoneList.Add(new Phone(7777777, "Nokia", 120));
            phoneList.Add(new Phone(5555555, "Sony", 200));
            phoneList.Add(new Phone(3333333, "Samsung", 240));
           foreach (var ph in phoneList) {
                Console.WriteLine(ph.ToString());
                Console.WriteLine(ph.GetNumber());
                Console.WriteLine(ph.ReceiveCall("John"));
                Console.WriteLine(ph.ReceiveCall("Arlo", 1111111));
                Console.WriteLine();
            }
            Console.WriteLine(Phone.SendMessage(1000000, 4561223, 7897889)); 
        }
   

	}

}