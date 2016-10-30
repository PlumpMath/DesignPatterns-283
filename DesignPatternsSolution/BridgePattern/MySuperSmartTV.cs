using System;

namespace BridgePattern
{
    internal class MySuperSmartTV
    {
        private IVideoSource _currentVideoSource = null;

        public IVideoSource VideoSource {
            get
            {
                return _currentVideoSource;
            }
            set
            {
                _currentVideoSource = value;
            }
        }

        public void ShowTvGuide()
        {
            Console.WriteLine(_currentVideoSource != null
                ? _currentVideoSource.GetTvGuide()
                : "Please select a Video Source");
        }

        public void PlayTV()
        {
            Console.WriteLine(_currentVideoSource != null
                ? _currentVideoSource.PlayVideo()
                : "Please Select a Video Source to Play"
            );
        }
    }
}