using System; 
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Telemantics
{
    public class Service
    {
        // Save a VehicleInfo as a JSON file that is the {vin}.json
        public void SaveVehicleInfoToJson(VehicleInfo info)
        {
            // use JSON.NET to conver the info to a 
            var json = JsonConvert.SerializeObject(info);
            Console.WriteLine(json);
            // write to a file callled (info.vin).json
        using (var VehicleInfo = new StreamWriter(File.Open("vin.json", FileMode.OpenOrCreate))) 
        {
          VehicleInfo.WriteLine("input here?"); 
        }
        //using var VehicleInfo = $"{info.vin}.json";

        }

        // Read all json files and create the html dashboard
        public void CreateDashboard()
        {
            // find all the json files
            // create an empty list of objecst
            // foreach json file
                // open the file
                // read the contents to a string
                // convert the string to a vechile info
                // var m = JsonConvert.DeserializeObject<VehicleInfo>(json);
                // add to List of objects
                
            // Come find me. 
        }

    }
}