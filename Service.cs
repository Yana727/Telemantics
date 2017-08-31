using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Telemantics
{
    public class Service
    {
        // Save a VehicleInfo as a JSON file that is the {vin}.json
        public void Report(VehicleInfo info)
        {
            // use JSON.NET to conver the info to a 


            // write to a file callled (info.vin).json
            using (var writer = new StreamWriter(File.Open($"{info.vin}.json", FileMode.OpenOrCreate)))
            {
                var json = JsonConvert.SerializeObject(info);
                writer.WriteLine(json);
            }

        }

        // Read all json files and create the dashboard
        public void CreateDashboard(VehicleInfo VehicleInfo)
        {
            string[] files = System.IO.Directory.GetFiles(".", "*.json");
            List<object> vehicleList = new List<object>();
            var totalOdometer = 0d;
            var totalConsumption = 0d;
            var totalLastOil = 0d;
            var totalEngine = 0d;
            var itemTemplate = @"<tr>
            <td align = 'center'>{0}</td>
            <td align='center'>{1}</td>
            <td align='center'>{2}</td>
            <td align='center'>{3}</td align='center'>
            <td align='center'>{4}</td>
            </tr>";
            var tableHTML = string.Empty;
            foreach (var item in files)
            {  // foreach json file
                using (StreamReader file = File.OpenText(item))

                {
                    var vehicleInfoObj = JsonConvert.DeserializeObject<VehicleInfo>(file.ReadToEnd());
                    vehicleList.Add(vehicleInfoObj);
                    totalOdometer += vehicleInfoObj.odometerMiles;
                    totalConsumption += vehicleInfoObj.gallons;
                    totalLastOil += vehicleInfoObj.oil;
                    totalEngine += vehicleInfoObj.engineSize;
                    tableHTML += string.Format($"{itemTemplate}", vehicleInfoObj.vin, vehicleInfoObj.odometerMiles, vehicleInfoObj.gallons, vehicleInfoObj.oil, vehicleInfoObj.engineSize);
                }
            }
            var odometerAvg = totalOdometer / vehicleList.Count;
            var consumpAvg = totalConsumption / vehicleList.Count;
            var lastOilAvg = totalLastOil / vehicleList.Count;
            var engAvg = totalEngine / vehicleList.Count;


            // using (var VehicleInfo = new StreamReader(File.Open("${info.vin}.json", FileMode.OpenOrCreate)))
            // {
            //     var text = VehicleInfo.ReadLine();
            //     Console.WriteLine(VehicleInfo);
            // }

        }

    }
}