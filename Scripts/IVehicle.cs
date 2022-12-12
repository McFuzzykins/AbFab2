using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IVehicle
{
    public string Speak();
}

public interface IVehicleFactory
{
    public IVehicle Create(VehicleRequirements reqs);
}

public class Unicycle : MonoBehaviour, IVehicle
{
    public string Speak()
    {
        return "Unicycle";
    }
}

public class Bicycle : MonoBehaviour, IVehicle
{
    public string Speak()
    {
        return "Bicycle";
    }
}

public class Tricycle : MonoBehaviour, IVehicle
{
    public string Speak()
    {
        return "Tricycle";
    }
}

public class Tandem : MonoBehaviour, IVehicle
{
    public string Speak()
    {
        return "Tandem";
    }
}

public class ShopCart : MonoBehaviour, IVehicle
{
    public string Speak()
    {
        return "Shopping Cart";
    }
}

public class FamilyBike : MonoBehaviour, IVehicle
{
    public string Speak()
    {
        return "Family Bike";
    }
}

public class Car : MonoBehaviour, IVehicle
{
    public string Speak()
    {
        return "Car";
    }
}

public class Motorcycle : MonoBehaviour, IVehicle
{
    public string Speak()
    {
        return "Motorcycle";
    }
}

public class Truck : MonoBehaviour, IVehicle
{
    public string Speak()
    {
        return "Truck";
    }
}

//everything below is production
public class Bronco : MonoBehaviour, IVehicle
{
    public string Speak()
    {
        return "Built Wild";
    }
}

public class Bronco93 : MonoBehaviour, IVehicle
{
    public string Speak()
    {
        return "The Juice Is Loose";
    }
}

public class newBronco : MonoBehaviour, IVehicle
{
    public string Speak()
    {
        return "Build Wild Again";
    }
}