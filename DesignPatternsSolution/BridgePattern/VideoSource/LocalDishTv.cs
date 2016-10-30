using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class LocalDishTv : IVideoSource
    {
        const string SOURCE_NAME = "Local DISH TV";

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
