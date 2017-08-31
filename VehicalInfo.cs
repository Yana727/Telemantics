using System; 

namespace Telemantics
{
    public class VehicleInfo
    {
        public int vin { get; set; }
        public double odometerMiles { get; set; }

        public double gallons { get; set; }

        public double oil { get; set; }

        public double engineSize { get; set; }

        public VehicleInfo(int vin, double odometerMiles, double gallons, double oil, double engineSize) 
        {
            this.vin = vin; 
            this.odometerMiles = odometerMiles;
            this.gallons = gallons;
            this.oil = oil;
            this.engineSize = engineSize;

        }
        public override string ToString()
        {
         return $"Vin: {vin}, Odometer: {odometerMiles}, Oil: {oil}, Engine Size: {engineSize}"; 
        } 

    }
}