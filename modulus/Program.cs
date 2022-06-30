using System;
using static System.Console;

namespace modulus
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount , saveAmnt;
            int twenties, tens, fives, ones;

            Write("Please enter the amount : ");
            amount =Convert.ToInt32(ReadLine());

            saveAmnt = amount;

            twenties = amount / 20;
            amount = amount % 20;
            tens = amount / 10;
            amount = amount % 10;
            fives = amount / 5;
            ones = amount % 5;

            //WriteLine(saveAmnt + " amount");
            WriteLine(twenties + " Twenties\n" + tens + " Tens\n" + fives + " Fives\n" + ones + " Ones");

        
        }
    }
}
