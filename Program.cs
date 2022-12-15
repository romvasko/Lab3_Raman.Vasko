

using Lab3.Classes;
using Lab3.Homework.ATM;
using Lab3.Homework.Clinic;
using Lab3.Homework.Computer;

namespace Lab3 
{
    internal class Program {
        static void Main(string[] args) {


            Computer computer = new Computer(5000, "Lenovo");
            Console.WriteLine(computer);
            Computer computer1 = new Computer(3000, "HP",new RAM("DDR4","16gb"),
                new HDD("Samsung","512gb","external"));
            Console.WriteLine(computer1);

            ATM atm = new ATM(10,10,10);
            Console.WriteLine(atm);
            Console.WriteLine(atm.AddMoney(150));
            Console.WriteLine(atm);
            Console.WriteLine(atm.RemoveMoney(890));
            Console.WriteLine(atm);
            Console.WriteLine(atm.RemoveMoney(1500));
            Console.WriteLine(atm);

            Patient p = new Patient(new CurePlan(1));
            Console.WriteLine(p.GetCure());
            Patient p1 = new Patient(new CurePlan(2));
            Console.WriteLine(p1.GetCure());
            Patient p2 = new Patient(new CurePlan());
            Console.WriteLine(p2.GetCure());

            //List<CreditCard> creditCards = new List<CreditCard>();
            //creditCards.Add(new CreditCard("111",200));
            //creditCards.Add(new CreditCard("222",200));
            //creditCards.Add(new CreditCard("333",999));
            //creditCards[0].AddCash(10);
            //creditCards[1].AddCash(20);
            //creditCards[2].GetCash(999);
            //foreach (var item in creditCards)
            //{
            //    Console.WriteLine(item); 
            //}

            // List<Phone> phoneList = new List<Phone>();
            // phoneList.Add(new Phone(7777777, "Nokia", 120));
            // phoneList.Add(new Phone(5555555, "Sony", 200));
            // phoneList.Add(new Phone(3333333, "Samsung", 240));
            //foreach (var ph in phoneList) {
            //     Console.WriteLine(ph.ToString());
            //     Console.WriteLine(ph.GetNumber());
            //     Console.WriteLine(ph.ReceiveCall("John"));
            //     Console.WriteLine(ph.ReceiveCall("Arlo", 1111111));
            //     Console.WriteLine();
            // }
            // Console.WriteLine(Phone.SendMessage(1000000, 4561223, 7897889)); 
        }


    }

}