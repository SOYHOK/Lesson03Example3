using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03Lab3
{
    class Account
    {
        private string strType;
        private string strName;
        private float fltBalance;
        public float Balance
        {
            get { return fltBalance; }
        }
        public Account(string x, string y, float z)
        {
            strType = x;
            strName = y;
            fltBalance = z;
        }
        public float CallInterest()
        {
            float interest = fltBalance * 0.018f;
            return interest;

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account accObj;
            Console.WriteLine("Enter the type of account: ");
            string Type = Console.ReadLine();
            Console.WriteLine("Enter the name of account: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the balance of account: ");
            float Balance = float.Parse(Console.ReadLine());
            accObj = new Account(Type, Name, Balance);

            Console.WriteLine("Balance ={0}", Balance);
            Console.WriteLine("interest = {0}", accObj.CallInterest());
            Console.ReadKey();

        }
    }
}
