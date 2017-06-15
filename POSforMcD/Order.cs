using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSforMcD
    {
    class Order
        {
        public int bigMacs { get; set; }
        public int fries { get; set; }
        public int cokes { get; set; }

        public void getOrder()
            {
            Console.WriteLine("Please state how any Big Macs you would like:  ");
            bigMacs = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please state how many packs of fries you would like:   ");
            fries = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please state how many cans of coke you would like:   ");
            cokes = Convert.ToInt16(Console.ReadLine());
           
            }

        }
    }
