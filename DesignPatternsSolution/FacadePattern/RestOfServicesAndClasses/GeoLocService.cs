namespace TestFacadePatternConsole
{
    public class GeoLocService
    {
        public Coordinates GetCoordinatesForZipCode(string zipcode)
        {
            return new Coordinates
            {
                Latitude = 10,
                Longitude = 20
            };
        }

        public string GetCityForZipCode(string zipCode)
        {
            return "Seattle";
        }

        public string GetStateForZipCode(string zipCode)
        {
            return "Washington";
        }
    }
}
