using System;
namespace codemoney
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string Text = Console.ReadLine().Replace(" ","");

            Solution.Decode(Text);

        }
    }
}