using System;
using System.Threading;

namespace WpfScrollTestNetCore
{
    public class SplashViewModel
    {
        public event Action Initialized;

        public ManualResetEvent SplashCreated { get; private set; }

        public SplashViewModel()
        {
            SplashCreated = new ManualResetEvent(false);
        }

        public void SetInitialized()
        {
            Initialized?.Invoke();
        }
    }
}
