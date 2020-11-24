using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AKotschevar2H1
{
    public class Ex2hCalculations
    {
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            string result = "Invalid Input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }
        public static string DateCalc07(string strDate)
        {
            string result = "Invalid Input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }
        public static string DateCalc08(string strDate)
        {
            string result = "1/1/0001";
            DateTime date;
            DateTime.TryParse(strDate, out date);
            result = date.ToShortDateString();

            return result;
        }
        //public static string DateCalc09(string StartDate, string EndDate)
        //{
        //    string result = "(32 Days)";
        //    DateTime date;
        //    try
        //    {
        //          DateTime.Parse(StartDate);
        //        DateTime.Parse(EndDate);
        //        date = TimeSpan.Parse(StartDate - EndDate).Days;
        //        result = TimeSpan.ToShortDateString();
        //        //result = date.TotalDays.ToString() + "days";
        //    }
        //    catch { }

        //    return result;
    //}
    //public static string DateCalc10(string s1, string s2, string s3)
    //{
    //    string result = "(Invalid Input)";
    //    DateTime date;
    //    try
    //    {
    //        DateTime.Parse(s1, s2, s3);
    //        DateTime daysPastDue = s1. Subtract (s2);
    //        result = daysPastDue.Day + "days past due";
    //        result = date.ToShortDateString()
    //    }

    //    catch { }
    //   result = date.TotalDays.ToString() + "days";
    //    return result;


    }
    }
    
    
