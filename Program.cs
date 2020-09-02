using System;
using System.Collections.Generic;

namespace Class_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Program p = new Program();
            p.VariablesTest();

            List<int> nums = new List<int>(){1,2,3,4,5,6,7,8,9,123,567,123,78,16,723,10,135,2,46,78};
            p.HomeWork(nums);

            //System.Console.WriteLine(nums);

        }
       public void HomeWork(List<int> numbers) {
            
            //int sum = nums.Sum()
            
            // 1 - print the sum of all numbers

            //System.Console.WriteLine("Sum: " + sum);        

            // 2 - print Only even numbers (use modulus (%) to determine if number is even, if result is 0, the number is even, is result is 1, the number is odd)
            // magic happens here to the set sum 

            System.Console.WriteLine("This is the solution");

        }
        void VariablesTest()
        {
            // declare variables
            // type name = value
            string firstName = "Lane";
            int age = 44;
            float f = 133.231f; // for anything else
            decimal total = 99.99m; // for money
            bool found = false;

            System.Console.WriteLine("Math Operations");
            System.Console.WriteLine(age - 1);
            System.Console.WriteLine(age + 1);
            System.Console.WriteLine(age * 32);
            System.Console.WriteLine(age / 2);
            System.Console.WriteLine(age % 2); // modulous operator

            // For Loop
            for (int i = 0; i < 10; i++)
            {
                // skip 3 and 7 (if i not equal to 3 and not equal to 7)

                if (i != 3 && i != 7)
                {
                    System.Console.WriteLine(i);
                }
            }

            // arrays (only use if you know exactly how many elements you will have)
            string[] names = new string[5];
            names[0] = "Wes";
            names[1] = "Letty";
            names[2] = "Kenny";
            names[3] = "Lane";
            names[4] = "Ebbonai";
            // will crash the program...names[5] = "Sergio";

            // if you don't know the actual size of the array, use a list that grows automatically as new elements are pushed
            var lastNames = new List<string>();
            lastNames.Add("Something");
            lastNames.Add("Another");
            lastNames.Add("Another Something");
            lastNames.Add("Another Another Something");
            lastNames.Add("Even More (Another) Something");

            // get the length of the list
            System.Console.WriteLine(lastNames.Count);
            for (int i = 0; i < lastNames.Count; i++)
            {
                System.Console.WriteLine(lastNames[i]);
            }

            // loop 
            foreach (string last in lastNames)
            {
                System.Console.WriteLine(last);
            }

        } // end method
    }
}
