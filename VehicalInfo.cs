using System; 

namespace Telemantics
{
    public class VehicalInfo
    {
        public int Vin { get; set; }
        public double odometerMiles { get; set; }

        public double gallons { get; set; }

        public double oil { get; set; }

        public double engineSize { get; set; }

        public VehicalInfo(int vin, double odometerMiles, double gallons, double oil, double engineSize)
        //Why do I have to repeat them? Do I have to? 
        {
            vin = vin; 
            odometerMiles = miles;//


        }
        public override string ToString()//bc it's all numbers? 
        {
         return $"Vin: {Vin}, Odometer: {odometerMiles}, Oil: {oil}, Engine Size: {engineSize}"; 
        } 

    }
}