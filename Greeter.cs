using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWeek2Challege
{
    public class Greeter
    {
        public string Name(string name)
        {
            return name;
        }
        static void Main(string[] args)
        {

            
            string outName;
            Greeter greeter = new Greeter();
            
            Console.WriteLine("Please Enter Your name: ");
            string userInput = Console.ReadLine();
            outName = greeter.Name(userInput);
            Console.WriteLine("Hello" + ' ' + outName) ;
            Console.WriteLine("Enter to exist.");
            Console.ReadLine();
            Console.WriteLine("Goodbye " + outName);
            Console.ReadLine();


            Console.WriteLine("please enter time between 0-23");
            int inputTime = Convert.ToInt32(Console.ReadLine());
            string outputTime = inputTime.ToString();
            string display = greeter.GreetingsTime(outputTime);
            Console.WriteLine(display);
            Console.ReadLine();


        }
        public string GreetingsTime(string greetings)
        {
            int time = Convert.ToInt32 (greetings);
            if(time >= 0 && time <12)
            {
                return "Good Morning";
            }

            else if (time >=12 && time < 18)
            {
                return "Good Afternoon";
            } 

            else
            {
                return "Good Evening";

            }
        }
    }
}
