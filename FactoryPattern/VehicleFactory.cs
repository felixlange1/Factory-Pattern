namespace FactoryPattern;

public static class VehicleFactory
{
    public static IVehicle GetVehicle(int numberOfTires)
    {

        switch (numberOfTires)
        {
            case <=2:
                return new Motorcycle();
            case >2:
                return new Car();
            default:
                return new Car();
        }
    }
}