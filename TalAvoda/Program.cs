using System;

class Program
{
    static void Main()
    {
        WaterHeater heater = new WaterHeater();
        DisplayUnit display = new DisplayUnit();
        AlarmSystem alarm = new AlarmSystem();


        heater.TemperatureChanged += display.OnTemperatureChanged;
        heater.TargetReached += alarm.OnTargetReached;

  
        heater.StartBoiler(70);

        Console.WriteLine("Heating process finished.");
        Console.ReadLine();
    }
}
