using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._05._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            // PRACTICE start

            //int number = 5;
            //string text = "Testing C#";
            //Console.WriteLine(number.GetType());
            //Console.WriteLine(typeof(int));
            //Console.WriteLine(sizeof(int));
            //Console.WriteLine(text.Substring(4,3));
            //Console.WriteLine(text.Substring(4));
            //int index = text.IndexOf("s");
            //Console.WriteLine(index);
            //Console.WriteLine(text.Contains("s"));

            //int number1;
            //int number2;
            //int number3;
            //int total;
            //Console.WriteLine("Enter first number");
            //number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second number");
            //number2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter third number");
            //number3 = int.Parse(Console.ReadLine());
            //total = number1 + number2 + number3;
            //Console.WriteLine(total);

            //int total = 0;
            //int length = int.Parse(Console.ReadLine());
            //for (int i = 0; i < length; i++)
            //{
            //    total += int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine(total);

            //Console.ReadLine();

            // PRACTICE end


            //HOME TASK 1

            //int total = 0;
            //int length = int.Parse(Console.ReadLine());

            //for (int i = 0; i <= length; i++)
            //{
            //total += i;
            //   //Console.WriteLine(i);
            //} 
            //Console.WriteLine("Total: {0}",total);

            //HOME TASK 2

            //int total = 0;
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= number; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        total += i;
            //    }
            //}
            //Console.WriteLine("Total: {0}",total);

            //HOMETASK 3

            //int total = 0;
            //string input = Console.ReadLine(); //" '3' '2' '8' "

            //First version

            //for (int i = 0; i < input.Length; i++)
            //{
            //    //Console.WriteLine(input[i]);
            //    int index = Convert.ToInt32(input[i].ToString());
            //    total += index;

            //}
            //Console.WriteLine("Total: {0}",total);

            //Second version

            //foreach (var item in input)
            //{
            //    total += Convert.ToInt32(item.ToString());
            //}
            //Console.WriteLine("Total: {0}",total);

            //HomeTask 4

            //string mail = Console.ReadLine();

            //First Version

            //if(mail.Contains("@gmail.com"))
            //{
            //    Console.WriteLine("Your email is correct ");
            //}
            //else
            //{
            //    Console.WriteLine("Please, input a valid email");
            //}

            //Second version

            //int index = mail.IndexOf("@gmail.com");

            //if (index != -1)
            //{
            //    Console.WriteLine("Your email is correct ");
            //}
            //else
            //{
            //    Console.WriteLine("Please, input a valid email");
            //}

        }
    }
}
