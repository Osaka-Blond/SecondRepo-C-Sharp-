using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrocharger_Prototype_Portfolio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setting up Title and Foreground Color
            Console.Title = "Electrocharger Prototype Portfolio Terminal";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WindowHeight = 32;
            Console.ReadKey();


            // Introduction/Abstract about the Electrocharger Project

            Console.WriteLine("This will be general information concerning the Electrocharger Prototype. ");

            Console.ReadLine();

            Console.WriteLine("This particular project will consists of a force induction-like system used for Electric-powered vehicles.");
            Console.WriteLine("The system consists of an impeller, a mechanical shaft, which will be made of carbon steel as well as a conductive rotor made of copper. ");
            Console.WriteLine("The conductive rotor will behave as a generator. ");
            Console.WriteLine("The force of the air will cause the impeller to rotate, thus spinning the rotor and creating a magenetic flux within the assembly. ");

            Console.ReadLine();

            Console.WriteLine("Click enter to view more information about the system");

            Console.ReadLine();

            Console.WriteLine("The purpose of this system is to convert a fluid, which is air in this case and transform that fluid into electricity.");
            Console.WriteLine("The process is very similar to a wind turbine. ");

            Console.ReadLine();

            // Parameters about mechanical shaft and RPM range of the shaft

            double yield_strength;
            int RPM;

            Console.WriteLine("Please enter the maximum yield stress for the mechanical shaft: ");
            yield_strength = Convert.ToDouble(Console.ReadLine());

            Console.ReadLine();

            Console.WriteLine("Please enter the maximum RPM range for the mechanical shaft: ");
            RPM = Convert.ToInt32(Console.ReadLine());

            Console.ReadLine();

            if (yield_strength > 248.168 && RPM == 14000)
                Console.WriteLine("Since the yield strength, " + yield_strength + " is greater, mechanical shaft is subjected to torsional stress. ");

            else if (yield_strength == 248.168 && RPM == 14000)
                Console.WriteLine("Since the yield strength equals, " + yield_strength + ", mechanical shaft has reached its stress limit. ");

            else
                Console.WriteLine("Mechanical shaft is not subjected to much stress. ");

            Console.ReadLine();
            Console.ReadKey();


            // Determining the RPM ranges

            Console.WriteLine("Press enter to display the value of the shaft speed: ");

            string[] shaft_speed = { "11000, 11050, 12000, 12050, 13000, 13050, 14000" };
            Console.ReadLine();

            foreach (string str in shaft_speed) 

            Console.WriteLine("Value of shaft speed is \n:" + str);
            Console.ReadLine();

            Console.WriteLine("In conclusion, these are the RPM ranges that are optimal for performance. ");
            Console.WriteLine("Anything over these parameters will be subjected to additional and unwanted stress. ");

            Console.ReadLine();
            Console.ReadKey();





        













        }
    }
}




















































