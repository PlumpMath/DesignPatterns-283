namespace TestFacadePatternConsole
{
    public class MetricConverterService
    {
        public double FarenheitToCelsius(double degrees)
        {
            return ((degrees - 32) / 9.0) * 5.0;
        }
    }
}