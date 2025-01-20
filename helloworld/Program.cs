// See https://aka.ms/new-console-template for more information
using System;
namespace ConsoleApplication
{
    class HelloWorld {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            GetSubString.test();
        }
    }

    class GetSubString //Getting a Substring
    {
        public static void test()
        {
            string str = "Last night I dreamt of San Pedro";
            Console.WriteLine(str);
            string substr = str.Substring(23);
            Console.WriteLine(substr);
        }

    }

}