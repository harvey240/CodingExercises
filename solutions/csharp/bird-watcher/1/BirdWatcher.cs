using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        // throw new NotImplementedException("Please implement the (static) BirdCount.LastWeek() method");

        return [0,2,5,3,7,8,4];
    }

    public int Today()
    {
        return birdsPerDay[^1];
        // throw new NotImplementedException("Please implement the BirdCount.Today() method");
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[^1]++;
        // throw new NotImplementedException("Please implement the BirdCount.IncrementTodaysCount() method");
    }

    public bool HasDayWithoutBirds()
    {
        foreach(int birds in birdsPerDay)
        {
            if (birds == 0)
            {
                return true;
            }
        }
        return false;
        // throw new NotImplementedException("Please implement the BirdCount.HasDayWithoutBirds() method");
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int count = 0;
        for (int i=0; i<numberOfDays; i++)
        {
            count += birdsPerDay[i];
        }

        return count;
        // throw new NotImplementedException("Please implement the BirdCount.CountForFirstDays() method");
    }

    public int BusyDays()
    {
        int count = 0;

        foreach(int birds in birdsPerDay)
        {
            if (birds >= 5)
            {
                count++;
            }
        }

        return count;
        // throw new NotImplementedException("Please implement the BirdCount.BusyDays() method");
    }
}
