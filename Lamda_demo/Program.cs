using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda_demo
{
    class Program
    {
        public delegate void PrintDelegate();
        public delegate void DisplayDelegate(string str, int x);
        public delegate int SquareDelegate(int n1);
        //public delegate void PrintDelegateWithParams(string str);
        //public void Print()
        //{
        //    Console.WriteLine("Msg from print function");
        //}
        //public void PrintParameters(string s)
        //{
        //    Console.WriteLine(s);
        //}
        static void Main(string[] args)
        {
            Program p = new Program();
            DisplayDelegate d2 = delegate (string n1, int n2)
             {
                 Console.WriteLine(n1);
                 Console.WriteLine(n2);
             };
            PrintDelegate d1 = delegate ()
              {
                  Console.WriteLine("Msg from anonymous function");
              };
            d1();
            d2("I am everywhere", 10);
            SquareDelegate d3 = (x => x * x);
            Console.WriteLine(d3(45));
            //PrintDelegate d1 = new PrintDelegate(p.Print);
            //PrintDelegateWithParams d2 = new PrintDelegateWithParams(p.PrintParameters);
            //d1();
            //d2("Message from print parameters");
        }
    }
}
