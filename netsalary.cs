using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int gross_salary, number_day; 
                
            float net_salary, allwonace ,tax,day_salary;

            Console.WriteLine("gross salary");

            gross_salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("number of days");

            number_day = Convert.ToInt32(Console.ReadLine());

            allwonace = 1000 + gross_salary;

            tax = (allwonace / 100) * 10;

            net_salary = allwonace - tax;

            day_salary = net_salary/number_day;

            Console.WriteLine("net salary=" + net_salary);
             Console.WriteLine("day salary="+day_salary);
            Console.ReadKey();



        }
    }
}
