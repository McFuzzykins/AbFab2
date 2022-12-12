using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct VehicleRequirements
{
    public int wheels;
    public int passengers;
    public bool hasEngine;
    public bool hasCargo;

    //production
    public bool pre2000;
    public bool onOJBday;
    public bool discontinued;
    public bool isBronco;
}

public abstract class AbstractVehicleFactory : MonoBehaviour
{
    public abstract IVehicleFactory CycleFactory();
    public abstract IVehicleFactory MotorVehicleFactory();

    //production
    public abstract IVehicleFactory BroncoFactory();
}

public class VehicleFactory : AbstractVehicleFactory
{
    public override IVehicleFactory CycleFactory()
    {
        return new CycleFactory();
    }

    public override IVehicleFactory MotorVehicleFactory()
    {
        return new MotorVehicleFactory();
    }
    
    //production
    public override IVehicleFactory BroncoFactory()
    {
        return new BroncoFactory();
    }
}

public class CycleFactory : IVehicleFactory
{
    public IVehicle Create(VehicleRequirements reqs)
    {
        switch (reqs.wheels)
        {
            case 1:
                return new Unicycle();
            case 2:
                if(reqs.passengers == 2) return new Tandem();
                return new Bicycle();
            case 3:
                return new Tricycle();
            case 4:
                if (reqs.hasCargo) return new ShopCart();
                return new FamilyBike();
            default:
                return new Bicycle();
        }
    }
}

public class MotorVehicleFactory : IVehicleFactory
{
    public IVehicle Create(VehicleRequirements reqs)
    {
        if(reqs.hasCargo)
        {
            return new Truck();
        }
        else if (reqs.wheels <= 2)
        {
            return new Motorcycle();
        }
        else
        {
            return new Car();
        }
    }
}

//production
public class BroncoFactory : IVehicleFactory
{
    public IVehicle Create(VehicleRequirements reqs)
    {
        if(reqs.hasCargo && reqs.onOJBday)
        {
            return new newBronco();
        }
        else if(reqs.hasCargo && reqs.discontinued && reqs.pre2000)
        {
            return new Bronco93();
        }
        else 
        {
            return new Bronco();
        }
    }
}


