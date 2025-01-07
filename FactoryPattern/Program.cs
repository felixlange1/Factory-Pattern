namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires should the vehicle have?");
            var tiresInput = int.Parse(Console.ReadLine());
            var vehicle = VehicleFactory.GetVehicle(tiresInput);
            
            vehicle.Drive();
        }
        
        
    }
}
