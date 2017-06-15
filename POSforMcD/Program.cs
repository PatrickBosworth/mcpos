using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSforMcD
    {
    class Program
        {
        static void Main(string[] args)
            {
            Person person1 = new Person();
            Console.WriteLine("Please enter your first name.");
            person1.firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name.");
            person1.lastName = Console.ReadLine();
            
            person1.SayHello();
            
            Order order1 = new Order();
            order1.getOrder();

            CalculateBill calcu = new CalculateBill();
            calcu.bigMacs = order1.bigMacs;
            calcu.fries = order1.fries;
            calcu.cokes = order1.cokes;

            Console.WriteLine(calcu.addUp());




            Console.ReadLine();
            // Console.WriteLine(Prices.bigMacPrice);





            }
        }
    }
