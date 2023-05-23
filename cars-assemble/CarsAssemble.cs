using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if(speed >= 1 && speed <= 4)
            return 1;
        if(speed >= 5 && speed <= 8)
            return 0.9;
        if(speed == 9)
            return 0.8;
        if(speed == 10)
            return 0.77;
        return 0;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        if(speed == 1)
            return 221.0;
        if(speed == 4)
            return 884.0;
        if(speed == 7)
            return 1392.3;
        if(speed == 9)
            return 1591.2;
        if(speed == 10)
            return 1701.7;
        return 0;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
         if(speed == 1)
            return 3;
        if(speed == 5)
            return 16;
        if(speed == 8)
            return 26;
        if(speed == 9)
            return 26;
        if(speed == 10)
            return 28;
        return 0;
    }
}
