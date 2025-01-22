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

            Vector v1 = new Vector(10, 15);
            Vector v2;
            v2 = --v1;
            v2.displayVector();
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

    class Vector {
        int x, y;
        public Vector() {}
        public Vector(int a, int b) {
            x = a;
            y = b;
        }

        public void displayVector() {
            Console.WriteLine("{0}, {1}", x, y);
        }

        // method for overloading unary minus
        public static Vector operator--(Vector v1) {
            v1.x = --v1.x;
            v1.y = --v1.y;
            return new Vector(v1.x, v1.y);
        }
    }
}