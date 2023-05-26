using System;

class RemoteControlCar
{
    public int Distance { get; set; }
    public int BatteryPercentage { get; set; }

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
        if(Distance >= 2000)
            Distance = 2000;
        return $"Driven {Distance} meters";
    }

    public string BatteryDisplay()
    {
        if(BatteryPercentage <= 0)
            return "Battery empty";
        return $"Battery at {BatteryPercentage}%";
    }

    public void Drive()
    {
        Distance += 20;
        BatteryPercentage--;
    }
}
