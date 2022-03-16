using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220316_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            double c=999;
            char op;
            Console.Write("Number1:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number2:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Operator(+, -, *, /):");
            op = Convert.ToChar(Console.ReadLine());

            switch(op)
            {
                case '+':
                    c = Convert.ToDouble(a + b);
                    break;
                case '-':
                    c = Convert.ToDouble(a - b);
                    break;
                case '*':
                    c = Convert.ToDouble(a * b);
                    break;
                case '/':
                    c = Convert.ToDouble(a / b);
                    break;
                default:
                    Console.WriteLine("無法執行你要求的運算");
                    break;
            }
            if (c != 999)
            Console.WriteLine("計算結果是:{0}", c);
            Console.ReadLine();
        }
    }
}
