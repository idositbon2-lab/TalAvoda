using System;

public class AlarmSystem
{
    public void OnTargetReached(object? sender, EventArgs e)
    {
        Console.WriteLine("[ALARM] Target temperature degrees reached! Powering off....");
    }
}
