using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{

    public class CalculatorClass
    {
        public delegate double Formula(double x, double y);
        
        public static double getSum(double x, double y) {

            return x+y;
        }
        public static double getDifference(double x, double y) {

            return x-y;
        }
        public static double getQuotient(double x, double y)
        {

            return x/y;
        }
        public static double getProduct(double x, double y)
        {

            return x*y;
        }
    }
}
