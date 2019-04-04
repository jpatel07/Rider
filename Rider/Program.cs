using Scheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rider
{
    class Program
    {
        static void Main(string[] args)
        {
            string stationName;
            string direction;
            int hour;
            int minute;
            TTCScheduler scheduler = new TTCScheduler();
            do
            {
                try
                {
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("Enter a Station:");
                    stationName = Console.ReadLine();
                    if (scheduler.ValidateStation(stationName))
                    {
                        Console.WriteLine($"Invalid Station {stationName}");
                    }

                    Console.WriteLine("Enter current hour:");
                    int.TryParse(Console.ReadLine(), out hour);

                    Console.WriteLine("Enter current minute:");
                    int.TryParse(Console.ReadLine(), out minute);

                    Console.WriteLine("Enter Direction:");
                    direction = Console.ReadLine();

                    TimeSpan nextTrainTime = scheduler.NextTrainArrivalTime(stationName, direction, hour, minute);

                    if (nextTrainTime.Ticks != 0)
                    {
                        Console.WriteLine($"Next Train {stationName} arrive at {nextTrainTime} for {direction}");
                    }

                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"Caught Errors {ex.Message}");
                    Console.WriteLine("------------------------------------------------------------");
                }

                Console.WriteLine("Enter 'q' to quit  or Enter to continue");
                Console.WriteLine("------------------------------------------------------------");


            } while (Console.ReadKey().KeyChar != 'q');

        }

    }
}

