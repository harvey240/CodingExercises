using System;

class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    public int speed;
    public int batteryDrain;

    private int battery = 100;
    private int metresDriven = 0;
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        if (battery < batteryDrain)
        {
            return true;
        }
        return false;
    }

    public int DistanceDriven()
    {
        return metresDriven;
    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
            battery -= batteryDrain;
            metresDriven += speed;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50,4);
    }
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    private int distance;
    
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        int numberOfDrives = (int) Math.Ceiling(((double)distance / car.speed));
        Console.WriteLine(numberOfDrives);
        int remainingBattery = 100 - (numberOfDrives * car.batteryDrain);
        Console.WriteLine(remainingBattery);
        if (remainingBattery < 0)
        {
            return false;
        }
        return true;
    }
}
