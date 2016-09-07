namespace TestFacadePatternConsole
{
    interface ITemperatureServiceFacade
    {
        LocalTemperature GetTemperature(string zipCode);
    }
}
