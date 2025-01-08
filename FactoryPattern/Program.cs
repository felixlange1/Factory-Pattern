namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var tiresCount = 0;
            Console.WriteLine("How many tires should the vehicle have?");
            int.TryParse(Console.ReadLine(), out tiresCount);
            var vehicle = VehicleFactory.GetVehicle(tiresCount);
            
            vehicle.Drive();
        }
        
        
    }
}
