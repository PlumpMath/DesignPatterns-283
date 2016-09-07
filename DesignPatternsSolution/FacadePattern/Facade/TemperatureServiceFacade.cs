using System.Threading;

namespace TestFacadePatternConsole
{
    public class TemperatureServiceFacadeFacade : ITemperatureServiceFacade
    {
        readonly WeatherService _weatherService;
        readonly GeoLocService _geoLocService;
        readonly MetricConverterService _metricConverterService;

        public TemperatureServiceFacadeFacade() : this(new WeatherService(), new GeoLocService(), new MetricConverterService())
        {
            
        }

        public TemperatureServiceFacadeFacade(WeatherService weatherService, GeoLocService geoLocService, MetricConverterService metricConverterService)
        {
            _weatherService = weatherService;
            _geoLocService = geoLocService;
            _metricConverterService = metricConverterService;
        }

        public LocalTemperature GetTemperature(string zipCode)
        {
            var coords = _geoLocService.GetCoordinatesForZipCode(zipCode);

            var city = _geoLocService.GetCityForZipCode(zipCode);
            var state = _geoLocService.GetStateForZipCode(zipCode);

            var farenheit = _weatherService.GetTempFarenheit(coords.Latitude, coords.Longitude);
            var celsius = _metricConverterService.FarenheitToCelsius(farenheit);

            var localTemperature = new LocalTemperature
            {
                Farenheit = farenheit,
                Celsius = celsius,
                City = city,
                State = state
            };

            return localTemperature;
        }
    }
}