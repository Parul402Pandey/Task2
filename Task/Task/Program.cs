
using System;
using System.Globalization;
using System.Collections.Generic;

namespace Task
{
    public class Program
    {
        public static void HoldMixedDataTypeValue()
        {
            /* Object[]  array=new Object[4];
                array[0]=1;
                array[1]="parul";
                array[2]=12.09;
                array[3]='p';
                foreach (Object obj in array)
                {

                    Console.WriteLine(obj);
                }       */
            List<Object> list = new List<Object>();
            list.Add(1);
            list.Add("Parul");
            list.Add(12.099);
            list.Add('p');
            foreach (var obj in list)
            {

                Console.WriteLine(obj);
            }

        }
        public static void CheckCurrentYearMonthDay()
        {

            Console.WriteLine("Enter the Year");
            int yearValue = int.Parse(Console.ReadLine());
            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;
            int currentDay = DateTime.Now.Day;
            try
            {
                if (yearValue == currentYear)
                {
                    Console.WriteLine("Enter a particular month");
                    int monthValue = int.Parse(Console.ReadLine());
                    if (monthValue == currentMonth)
                    {
                        Console.WriteLine("Enter a particular day");
                        int dayValue = int.Parse(Console.ReadLine());
                        if (dayValue == currentDay)
                        {
                            Console.WriteLine("Valid entered value");
                        }
                        else
                        {
                            Console.WriteLine("The entered day is not a Current year");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The entered  month is not a Current year");
                    }
                }
                else
                {
                    Console.WriteLine("The entered year is not a Current year");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void DayForParticularDate()
        {
            Console.WriteLine("Enter a date it must be in such a foramt mm/dd/yy");
            //getting date from user
            String particulardate = Console.ReadLine();
            DateTime dateValue;
            DateTimeOffset dateCulture;
            try
            {
                DateTimeFormatInfo dateTimeFormats;
                dateValue = DateTime.Parse(particulardate, CultureInfo.InvariantCulture);
                Console.Write(dateValue.ToString("dddd"));

            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

        }
        public static void Main(string[] args)
        {
            // DayForParticularDate();
            // CheckCurrentYearMonthDay();
            HoldMixedDataTypeValue();
        }
    }
}
