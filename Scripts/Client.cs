using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Client : MonoBehaviour
{
    [Header("Options")]
    public Button create;
    public Toggle hasEngine;
    public Toggle hasCargo;
    public Slider pass;
    public Slider wheels;

    //production
    public Toggle onOJsBDay;
    public Toggle discontinued;
    public Toggle pre2000;
    public Toggle isBronco;

    public VehicleRequirements req;
    IVehicle x;

    //production
    public TMP_Text text;

    public void OnCreate()
    {
        x = GetVehicle(req);
        text.text = x.Speak();
    }
    
    static IVehicle GetVehicle(VehicleRequirements req)
    {
        var factory = new VehicleFactory();
        IVehicle vehicle;


        /* production
        if (req.hasEngine && req.isBronco)
        {
             vehicle = factory.BroncoFactory().Create(req);
        }
        else if (req.hasEngine)
        {
           vehicle = factory.MotorVehicleFactory().Create(req);
        }
        else
        {
            vehicle = factory.CycleFactory().Create(req);
        }
        return vehicle;
        */

        if (req.hasEngine)
        {
           vehicle = factory.MotorVehicleFactory().Create(req);
        }
        else
        {
            vehicle = factory.CycleFactory().Create(req);
        }
        return vehicle;
    }

    void Update()
    {
        req.hasEngine = hasEngine.isOn;
        req.hasCargo = hasCargo.isOn;
        req.passengers = (int)pass.value;
        req.wheels = (int)wheels.value;

        //production
        req.isBronco = isBronco.isOn;
        req.onOJBday = onOJsBDay.isOn;
        req.discontinued = discontinued.isOn;
        req.pre2000 = pre2000.isOn;
    }
}
