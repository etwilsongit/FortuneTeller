using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt the user for their name 
            Console.WriteLine("<Please enter your FIRST NAME\n>");
            string firstName = Console.ReadLine();
            
            //Prompt the user for their last name
            Console.WriteLine("<Please enter your LAST NAME\n");
            string lastName = Console.ReadLine();

            //Prompt the user for their age
            Console.WriteLine("<Think of your AGE, is the number odd or even? Enter ODD or EVEN now\n>");
            string age = Console.ReadLine();
            switch (age)
            {
                case "even":
                    Console.WriteLine("50");
                    break;
                case "odd":
                    Console.WriteLine("30");
                    break;

            }

            //Prompt the user for their birth month
            Console.WriteLine("Please enter your BIRTH MONTH with whole numbers:\n");
            int month = int.Parse(Console.ReadLine());

            switch (month)
            {
            
            //The months are listed here as integers, including the monitary number chosen for each group of months
                case 1:
                    Console.WriteLine("$500");
                    break;
                case 2:
                    Console.WriteLine("$500");
                    break;
                case 3:
                    Console.WriteLine("$500");
                    break;
                case 4:
                    Console.WriteLine("$500");
                    break;
                case 5:
                    Console.WriteLine("$10,000");
                    break;
                case 6:
                    Console.WriteLine("$10,000");
                    break;
                case 7:
                    Console.WriteLine("$10,000");
                    break;
                case 8:
                    Console.WriteLine("$10,000");
                    break;
                case 9:
                    Console.WriteLine("50,000");
                    break;
                case 10:
                    Console.WriteLine("50,000");
                    break;
                case 11:
                    Console.WriteLine("50,000");
                    break;
                case 12:
                    Console.WriteLine("50,000");
                    break; 
            }

            if (month < 1)
            {
                Console.WriteLine("$0.00");
            }
            else if (month <= 13)
            {
                Console.WriteLine("$0.00");
            }
          


            //Prompt the user to supply their favorite ROYGBIV color
            Console.WriteLine("<Please enter your favorite ROYGBIV color>\n***If you do not know what ROYGBIV colors are please enter'HELP' now***\n");
            string color = Console.ReadLine();

            switch (color)
            {
                //The colors are listed here as cases, including the mode of transportation chosen for each color
                case "help":
                    Console.WriteLine("red, orange, yellow, green, blue, indigo, violet");
                    break;
                case "red":
                    Console.WriteLine("basic silver Volvo");
                    break;
                case "orange":
                    Console.WriteLine("jet black Audi");
                    break;
                case "yellow":
                    Console.WriteLine("yellow Volkswagen Beetle");
                    break;
                case "green":
                    Console.WriteLine("white Fiat");
                    break;
                case "blue":
                    Console.WriteLine("navy blue Mini Cooper");
                    break;
                case "indigo":
                    Console.WriteLine("white and blue vintage Volkswagen Bus");
                    break;
                case "violet":
                    Console.WriteLine("red Lexus Rx");
                    break;

            }
            //Prompt user to input the number of siblings they have or do not have
            Console.WriteLine("<Enter the NUMBER OF SIBLINGS you have in whole numbers\n>");
            int sibNum = int.Parse(Console.ReadLine());
            switch (sibNum)
            {
                //The number of siblings are listed here as integers
                case 0:
                    Console.WriteLine("Maui, Hawaii");
                    break;
                case 1:
                    Console.WriteLine("Chautauqua, New York");
                    break;
                case 2:
                    Console.WriteLine("New Orleans, Louisiana");
                    break;
                case 3:
                    Console.WriteLine("Las Vegas, Nevada");
                    break;
                case 4:
                    Console.WriteLine("Aspen, Colorado");
                    break;
                case 5:
                    Console.WriteLine("LA, California");
                    break;
                case 6:
                    Console.WriteLine("Oaxaca, Mexico");
                    break;
                case 7:
                    Console.WriteLine("Paris, France");
                    break;
                case 8:
                    Console.WriteLine("Milan, Italy");
                    break;
                case 9:
                    Console.WriteLine("Fukuoka, Japan");
                    break;
                case 10:
                    Console.WriteLine("Orlando, Florida");
                    break;
            }
            //Share the results with the user 
            Console.WriteLine("Congratulations! These are your results:\n");
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine((age) + "years from now, you will retire");
            Console.WriteLine((month) + "is the amount of money you will have in your bank account");
            Console.WriteLine("You will have a vacation home in" + (sibNum));
            Console.WriteLine("You will be driving a" + (color));
        
            //Console.WriteLine((firstName + lastName) will retire (age) from now, with (month) in the bank, a vacation home in (sibNum) and a (color));
            
            }
    }
}
