using System;

namespace TestFacadePatternConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            const string zipCode = "SeattleZipCode";

            ITemperatureServiceFacade temperatureService = new TemperatureServiceFacadeFacade();

            var localTemp = temperatureService.GetTemperature(zipCode);

            Console.WriteLine("The current temperature is {0}F/{1}C. in {2}, {3}",
                        localTemp.Farenheit.ToString("F1"),
                        localTemp.Celsius.ToString("F1"),
                        localTemp.City,
                        localTemp.State);

            Console.ReadKey();
        }
    }
}