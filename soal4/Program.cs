/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Prime_Number
    {
        private int num1;
        private int num2;
        public int Num1
        {
            get { return num1; }
            set
            {
                if (value > 0)
                {
                    num1 = value;
                }
            }
        }
        public int Num2
        {
            get { return num2; }
            set
            {
                if (value > 0)
                {
                    num2 = value;
                }
            }
        }
        public Prime_Number()
        {

        }
        public Prime_Number(int input1, int input2)
        {
            Num1 = input1;
            Num2 = input2;
        }
        public void Print_number()
        {
            for (int i = num1; i <= num2; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i - 1; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                    }
                }
                if (counter < 1)
                {
                    Console.WriteLine("Number " + i + " is Prime");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int input_1 = Convert.ToInt32(Console.ReadLine());
            int input_2 = Convert.ToInt32(Console.ReadLine());
            Prime_Number pr = new Prime_Number(input_1, input_2);
            pr.Print_number();
            Console.ReadKey();
        }
    }
}
*/
using System;
using System.Diagnostics.Metrics;

namespace project
{
    class number
    {
        private int num1;
        private int num2;
        public int Num1
        {
            get { return num1; }
            set { num1 = value; }

        }
        public int Num2
        {
            get { return num2; }
            set { num2 = value; }

        }
        public number() { }
        public number(int a, int b)
        {
            num1 = a; num2 = b;
        }
        public void p()
        {
            for (int i = num1; i <= num2 - 1; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i; j++)
                {


                    if (i % j == 0)
                    {
                        counter++;

                    }
                    if (counter < 1)
                    {
                        Console.WriteLine("number" + i + "aval");
                    }
                }
                }
            }
        public static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            number number = new number(x, y);
            number .p();
        }
    }
}