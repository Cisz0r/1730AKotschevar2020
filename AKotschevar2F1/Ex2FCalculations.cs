using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AKotschevar2F1
{
    public class Ex2fCalculations
    {
        public static string Calc01(string input)
        {
            // #1: if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            return discountPercent.ToString("n2");
        }
        public static string Calc02(string input)
        {
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            string status = "Standard rate: ";
            if (subtotal >= 100m)
            {
                discountPercent = 0.2m;
                status = "Bulk rate: " + discountPercent.ToString("n2");
            }
            return status;
        }
        public static string Calc03(string input)
        {
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }
        public static string Calc04(string input)
        {
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100 && subtotal < 200)
                discountPercent = 0.2m;
            else if (subtotal >= 200m && subtotal < 300)
                discountPercent = 0.3m;
            else if (subtotal >= 300m)
                discountPercent = 0.4m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc05(string input)
        {
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 300)
                discountPercent = 0.4m;
            else if (subtotal >= 200m)
                discountPercent = 0.3m;
            else if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc06(string inputA, string inputB)
        {
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(inputA);
            string customerType = inputB;
            discountPercent = 0m;
            if (customerType == "R")
            {
                if (subtotal >= 100m)
                    discountPercent = 0.2m;
                else
                    discountPercent = 0.1m;
            }
            else          // customerType isn't "R"
                discountPercent = 0.4m;
            return discountPercent.ToString("n2");
        }
        public static string Calc07(string input)
        {
            // #7 Validate input: non-empty string
            decimal ethereum = 0m;
            if (input != "")
            {
                decimal dollars = Decimal.Parse(input);
                ethereum = 200m * dollars;
                return ethereum.ToString("n2");
            }
            return "Invalid input";
        }
        public static string Calc08(string inputA, string inputB)
        {
            // #8 Validate input, calculate quantity * price, shipping
            //The if statement should check for whether the value is less than 50, and then the code after 
            //the if statement, if true, should add 50 to the value.
            decimal total = 0m;
                if (inputA != "" && inputB != "")
                {                                                    
                decimal price = Decimal.Parse(inputA);
                decimal quantity = Decimal.Parse(inputB);
                total = price * quantity;
                if (price <= 24.99m)
                    total += 5m;
                { 
                    return total.ToString("n2");
                }
            }
                return "Invalid input";
            }
        public static object Calc09(string inputA, string inputB)
    {
        // #9 Validate input, calculate difference * rate
        // multiply it by the rate per KwH (which is a static 0.1)

            decimal total = 0m;
            if (inputA != "" && inputB != "")
            {
                decimal difference = Decimal.Parse(inputA);
                decimal rate = Decimal.Parse(inputB);
                int a = 10000; int b = 11000;
                int result = b - a;
                difference = 1000;
                {
                    rate = 0.1m;
                }
                total = difference * rate;
                {
                    return total.ToString("n2");
                }
            }
            return "Invalid input";
        }
        public static string Calc10(string inputA, string inputB)
        {
            //#10 Validate input, divide large num by small Both numbers must be > 0
            // if decimal1 > decimal2, result is decimal1 / decimal2
            // if decimal2 > decimal1, result is decimal2 / decimal1
            // if decimal1 = decimal2 then divide either by the other, doesn't matter

            double result = 0.0;
            if (inputA != "" && inputB != "")
            {
                decimal d1 = Decimal.Parse(inputA);
                decimal d2 = Decimal.Parse(inputB);
                if (d2 == 0 || d1 == 0)
                    return "Invalid input";
                else if (d2 > d1)
                    result = ((double)(d2 / d1));
                else if (d1 > d2)
                    result = ((double)(d1 / d2));
                else if (d1 == d2)
                    result = 1;
                else if (d1 <= d2)
                    result = 0;
                return result.ToString("n2");

            }
            else
                return "Invalid input";
             

        }
    }
}

