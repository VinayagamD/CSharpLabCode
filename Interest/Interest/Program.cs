using System;

namespace Interest
{
    class Program
    {
        static void Main(String[] args)
        {
            int year;
            double principleAmount, rate, interest, totalAmount;

            Console.Write("Enter The Loan Amount : ");

            principleAmount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter The Number Of Years : ");

            year = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter the Rate  Of Interests : ");

            rate = Convert.ToDouble(Console.ReadLine());

            interest = principleAmount * year * rate / 100;

            totalAmount = principleAmount + interest;

            Console.WriteLine("Total Amount: {0}", totalAmount);

            Console.ReadLine();

        }
    }
}
