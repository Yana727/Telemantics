using System;

namespace Telemantics
{
    class Program
    {
        static void Main(string[] args)
        {   //where the data is coming from. PS: the users... 
            Console.WriteLine("Please enter Vehicle Identification Number:");
            var vinInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the Odometer reading:");
            var odometerInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the miles per gallons for the vehicle:");
            var consumptionInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the Odometer reading from the last oil change:");
            var odometerLastOilChangeInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the Engine size of the vehicle:");
            var engineSizeInput = int.Parse(Console.ReadLine());
            

            var newVehicle = new VehicleInfo(vinInput, odometerInput, consumptionInput, odometerLastOilChangeInput, engineSizeInput); 
            new Service().SaveVehicleInfoToJson(newVehicle);
            //The file will overwrite any existing files for the same VIN.


            // #2 Find all the files that end with ".json" and convert back to a VehicleInfo object.

            // #3 Update a dashboard.html (only show 1 place after the decimal for values that are doubles). 
            //The dashboard.html should look something like this (with the '#' replaced with a number)

        }
    }
}
