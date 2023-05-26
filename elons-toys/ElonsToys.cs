using System;

class RemoteControlCar
{
    public decimal Distance { get; set; }
    public decimal BatteryPercentage { get; set; }

    public RemoteControlCar()
    {
        Distance = 0;
        BatteryPercentage = 100;
    }

    public static RemoteControlCar Buy()
    {
        var newCar = new RemoteControlCar();
        return newCar;
    }

    public string DistanceDisplay()
    {
        return $"Driven {Distance} meters";
    }

    public string BatteryDisplay()
    {
        return $"Battery at {BatteryPercentage}%";
    }

    public void Drive()
    {

    }
}
