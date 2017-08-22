using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            ////first try
            //int costTotal = 120;
            //if(costTotal >= 50)
            //{
            //    Console.WriteLine("Congratulations your bill total qualifies for a 10% discount!");
            //}
            //else
            //{
            //    Console.WriteLine("Congratulations your bill total qualifies for a 5% discount!");
            //}

            //Lets try this one out

            //Console.WriteLine("How old are you?");
            //int userAge = int.Parse(Console.ReadLine());
            //if (userAge >= 15)
            //{
            //    Console.WriteLine("Here is your ticket to the movie!");
            //        }

            //else
            //{
            //    Console.WriteLine("I'm sorry, go home, you are not old enough to watch this.  I'm telling your dad!");                    
            //        }  



            //Console.WriteLine("Please enter your age");
            //int userAge = int.Parse(Console.ReadLine());
            //if(userAge >=0 && userAge <=2)
            //{
            //    Console.WriteLine("Still in mama's arms");
            //}

            //Console.WriteLine("Enter your percentage");
            //int grade = int.Parse(Console.ReadLine());
            //if (grade >=90 && grade <= 100)
            //{
            //    Console.WriteLine("You got an A!!");
            //}
            //else if(grade >=80 && grade <=89)
            //{
            //    Console.WriteLine("You got a B!!  Not Bad");
            //}

            //int costTotal = 120;
            //if (costTotal >= 50)
            //{
            //    Console.WriteLine("Congratulations your bill total qualifies for a 10% discount!");
            //}
            //else
            //{
            //    Console.WriteLine("Congratulations your bill total qualifies for a 5% discount!");
            //} 

            //Console.WriteLine("How many people are at your table?");
            //int peopleTotal = int.Parse(Console.ReadLine());
            //Console.WriteLine("Thank you, what is the cost of your total bill?");
            //double tableCost = double.Parse(Console.ReadLine());
            //if (tableCost >= 50)
            //{
            //    Console.WriteLine("Congratulations, your bill total qualifies for a 10% discount");
            //    double tableDeduction = .10 * tableCost;                
            //    Console.WriteLine("Here is your new total.");
            //    Console.WriteLine(tableCost - tableDeduction);
            //    double tableTotal = tableCost - tableDeduction;
            //    double personTotal = tableTotal / peopleTotal;
            //    Console.WriteLine("Your cost per person is " + personTotal);

            //}
            //else if (tableCost < 50)
            //{
            //    Console.WriteLine("Congratulations, your bill total qualifies for a 5% discount");
            //    double tableDeduction = .05 * tableCost;
            //    Console.WriteLine("Here is your new total.");
            //    Console.WriteLine(tableCost - tableDeduction);
            //}

            //Console.WriteLine("Please enter your age");
            //int userAge = int.Parse(Console.ReadLine());
            //if (userAge >= 0 && userAge <= 2)
            //{
            //    Console.WriteLine("Still in mama's arms");
            //}
            //else if (userAge == 3 || userAge == 4)
            //{
            //    Console.WriteLine("Preschool Maniac");
            //}
            //else if (userAge >= 5 && userAge <= 11)
            //{
            //    Console.WriteLine("Elementary School");
            //}
            //else if (userAge >=12 && userAge <=14)
            //{
            //    Console.WriteLine("Middle School");
            //}
            //else if (userAge >=15 && userAge <= 18)
            //{
            //    Console.WriteLine("High School");
            //}
            //else if (userAge >=19 && userAge <=22)
            //{
            //    Console.WriteLine("College");
            //}
            //else if (userAge >=23 && userAge <= 65)
            //{
            //    Console.WriteLine("Working for the man");
            //}
            //else if (userAge >= 66 && userAge <= 100)
            //{
            //    Console.WriteLine("The Golden Years");
            //}
            //else
            //{
            //    Console.WriteLine("This program is for humans");
            //}

            //Console.WriteLine("Please enter a number");
            //int userNumber = int.Parse(Console.ReadLine());
            //int divisibleNumber = 2;
            //int remainder = userNumber / divisibleNumber;
            //if (remainder % 2 == 0)
            //{
            //    Console.WriteLine("Your number is even");
            //}
            //else
            //{
            //    Console.WriteLine("Your number is odd");
            //}


            Console.WriteLine("Please enter a number");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber % 2 == 0)
            {
                Console.WriteLine(userNumber + " is even");
            }
            else
            {
                Console.WriteLine(userNumber + " is odd");
            }
















        }

    }
}
