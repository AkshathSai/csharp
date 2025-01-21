// See https://aka.ms/new-console-template for more information
using System;
namespace ConsoleApplication
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            GetSubString.test();
            JoiningStrings joiningStrings = new JoiningStrings();
            joiningStrings.test();
            string[] alphabets = new string[]{"d","b","a","c"};
            Console.WriteLine(alphabets);
            Console.WriteLine("Unsorted: " + string.Join(", ", alphabets));
            Array.Sort(alphabets);
            Console.WriteLine("Sorted: " + string.Join(", ", alphabets));
            
            int num = 10;
            Console.WriteLine("Value of num before calling function: " + num);
            PassByReferenceSample passByReferenceSample = new PassByReferenceSample();
            passByReferenceSample.test(ref num);
            Console.WriteLine("Value of num after calling function: " + num);
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

    class JoiningStrings
    {
        public void test()
        {
            string[] starray = new string[]{
            "Down the way nights are dark", 
            "And the sun shines daily on the mountain top",
            "I took a trip on a sailing ship",
            "And when I reached Jamaica",
            "I made a stop"};
            string str = String.Join("\n", starray); Console.WriteLine(str);
        }
    }

    class PassByReferenceSample {
        public void test(ref int num) {
            num++;
        }
    }
}