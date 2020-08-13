using System;
using System.Collections.Generic;
using System.Linq;


namespace PlingPlangPlong
{
    class Program
    {

        public static IEnumerable<int> Factor(int number)
        {
            var searched = Enumerable.Range(1, number)
                 .Where((x) => number % x == 0)
                 .Select(x => number / x);

            foreach (var s in searched)
                  yield return s;
            
            
        }
        static void Main(string[] args) 
        {
           Console.WriteLine("type exit to quit.");
            while (true)
            {
                Console.WriteLine("Returns a response other than what you have entered, if the entered amount has factors 3/5/ or 7.");
                string userInput = Console.ReadLine();

                if(userInput.ToLower() == "exit")
                {
                    break;
                }
                else
                {

                    try
                    {
                        var Leachtastic = Factor(Convert.ToInt32(userInput));
                        int x = 0;
                        foreach (int f in Leachtastic.Reverse<int>())
                        {

                       
                            if (f == 3)
                            {
                                Console.Write(" Pling");
                                x = 1;
                            }
                            if (f == 5)
                            {
                                Console.Write(" Plang");
                                x = 1;
                            }
                            if (f == 7)
                            {
                                Console.Write(" Plong");
                                x = 1;
                            }




                        }
                        if (x == 0)
                        {
                            Console.WriteLine(userInput);
                        }

                        Console.ReadLine();


                    }

                    catch
                    {
                        Console.WriteLine("You have not entered a whole number...");
                        Console.ReadLine();
                    }
                   
                
                }
            }
            Environment.Exit(0);
        }
    }
}
