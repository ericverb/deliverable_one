using System;

namespace Deliverable1
{
    internal class Program
    {
        static void Main()
        {
            var doStuff = true;

            while (doStuff)
            {
                //Ask for number of people
                Console.Write("How many people are we making PB&J sandwiches for?");
                string input = Console.ReadLine();
                int numPeople = int.Parse(input);
                Console.WriteLine(numPeople);

                int sliceBread = numPeople * 2;
                int tbspPb = numPeople * 2;
                int tbspJelly = numPeople * 4;
                double loavesBread = numPeople * 2;
                loavesBread = Math.Ceiling(loavesBread / 28);
                double jarsPb = numPeople * 2;
                jarsPb = Math.Ceiling(jarsPb / 32);
                double jarsJelly = numPeople * 4;
                jarsJelly = Math.Ceiling(jarsJelly / 48);

                string strOutPut = "@@@You need:  @@@" + sliceBread + "  slices of bread@" + tbspPb +
                                   "  tablespoons of peanut butter@" + tbspJelly + "  teaspoons of jelly@@@" +
                                   "which is ...@@@" + loavesBread + "  loaves of bread@" + jarsPb +
                                   "  jars of peanut butter@" + jarsJelly + "  jars of jelly@@@" +
                                   "Would you like to restart? Enter yes or y to continue, or enter any other key to exit.";
                strOutPut = strOutPut.Replace("@", Environment.NewLine);
                Console.WriteLine(strOutPut);
                string runAgain = Console.ReadLine();

                //Run Again
                if (runAgain == "yes" || runAgain == "y")
                {
                    doStuff = true;
                }
                else
                {
                    doStuff = false;
                    Console.WriteLine("Goodbye!");
                }
            }
        }
    }
}