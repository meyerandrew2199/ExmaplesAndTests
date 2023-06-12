using System;
using System.Collections.Generic;

namespace Practice
{
    class Garbage
    {

        static void Main(string[] args)
        {


            /* Que */

            Queue<int> orderNumbers = new Queue<int>();
            orderNumbers.Enqueue(1112);
            orderNumbers.Enqueue(1113);
            orderNumbers.Enqueue(1114);
            orderNumbers.Dequeue();

            foreach (int orderNumber in orderNumbers)
            {
                Console.WriteLine(orderNumber);
            }


            /* Garbage collector */

            GC.Collect();
            Console.WriteLine("The total memrory you are using is:{0}", GC.GetTotalMemory(true));

            Console.WriteLine("Max gen:{0}", GC.MaxGeneration);

            Console.WriteLine("Welcome to this high level language");


            /* Repet words x amount of times (loop) */

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine("Test!");
            }



            /* Switch case testing.... not done

                 string customerStatus = List<"Gold", "Silver", "Bronze" >
             switch (customerStatus)
             {

                 case "Gold":
                     disc = .1;



             }
             */

            /* Array/list of locations, foreach loop*/

            string[] Locations = { "Locations are:" };
            Console.WriteLine("{0}", Locations);
            string[] cities = { "Detroit", "Atlanta", "Columbus" };
            foreach (string s in cities)


                Console.WriteLine(s);


            /* while loop for items in cart plus message */


            int x = 1;

            /*  while (x <= 5)  */
            do

            {
                Console.WriteLine("You have {0} items in your cart!", x);
                x++;
            }
            while (x <= 0);

            if (x <= 3)
            {
                Console.WriteLine("It looks like you don't have alot of items in your cart, you should add more!");
            }

            else
                Console.WriteLine("Thats alot of items!!");






            /* question game */

            string result = question();
            Console.WriteLine(result);

            string question()
            {
                Console.WriteLine("What is the capital of Colorado?");
                string answer = Console.ReadLine();

                if (answer == "Denver")
                { Console.WriteLine("YOU WIN!!!"); }
                else question();
                return "Game Over LOL";
            }




                /* Structured excemption handling*/

                int a = 5;
                int b = 0;
                    try
                {
                    Console.WriteLine(a / b);
                }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please input valid numbers and try again");
            }
        finally
            {
                Console.WriteLine("*****~~~Code Complete~~~*****");
                Console.WriteLine("Have a good day =)!!!");
            }
                                             
        
        }
     

    }

}

    



