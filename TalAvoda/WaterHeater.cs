using System;
using System.Threading;
using TalAvoda;

public class WaterHeater
{
    public double CurrentTemperature { get; set; }
    public event EventHandler<TemperatureChangedEventArgs>? TemperatureChanged;
    public event EventHandler? TargetReached;

    public void StartBoiler(double targetTemp)
    {
        CurrentTemperature = 20; 
        while (CurrentTemperature < targetTemp)
        {
            Thread.Sleep(500);
            CurrentTemperature += 2;

     
            TemperatureChanged?.Invoke(
                this,
                new TemperatureChangedEventArgs(CurrentTemperature, DateTime.Now)
            );
        }
        TargetReached?.Invoke(this, EventArgs.Empty);
    }
}
