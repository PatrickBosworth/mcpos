using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSforMcD
    {
    class CalculateBill
        {
        public double bigMacs { get; set; }
        public double fries { get; set; }
        public double cokes { get; set; }
        

        public double addUp()
           {
            double total = bigMacs * Prices.bigMacPrice;

            total += fries * Prices.friesPrice;
            total += cokes * Prices.cokePrice;

            return total;
           }
        }
    }
