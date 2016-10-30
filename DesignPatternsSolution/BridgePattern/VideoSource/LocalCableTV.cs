namespace BridgePattern
{
    class LocalCableTV : IVideoSource
    {
        const string SOURCE_NAME = "Local Cabel TV";

        string IVideoSource.GetTvGuide()
        {
            return $"Getting TV guide from - {SOURCE_NAME}";
        }

        string IVideoSource.PlayVideo()
        {
            return $"Playing - {SOURCE_NAME}";
        }
    }
}
