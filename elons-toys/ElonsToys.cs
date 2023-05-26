using System;

class RemoteControlCar
{
    public static RemoteControlCar Buy()
    {
        var newCar = new RemoteControlCar();
        return newCar;
    }

    public string DistanceDisplay()
    {
        return "Driven 0 meters";
    }

    public string BatteryDisplay()
    {
        return "Battery at 100%";
    }

    public void Drive()
    {
        throw new NotImplementedException("Please implement the RemoteControlCar.Drive() method");
    }
}
