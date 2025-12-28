using System;
using TalAvoda;

public class DisplayUnit
{
    public void OnTemperatureChanged(object? sender, TemperatureChangedEventArgs e)
    {
        Console.WriteLine(
            $"[Display] Current Temperature: {e.CurrentTemperature:F1} at {e.TimeMeasured:HH:mm:ss}"
        );
    }
}
