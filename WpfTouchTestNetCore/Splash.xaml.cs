using System;
using System.Windows;
using System.Windows.Input;

namespace WpfScrollTestNetCore
{
    /// <summary>
    /// Interaction logic for Splash.xaml
    /// </summary>
    public partial class Splash : Window
    {
        private SplashViewModel Context => DataContext as SplashViewModel;

        public Splash()
        {
            InitializeComponent();
            Loaded += OnSplashLoaded;
            Closed += OnClosed;
        }

        private void OnSplashLoaded(object sender, RoutedEventArgs e)
        {
            Cursor = Cursors.None;

            Context.Initialized += OnSystemInitialized;
            Context.SplashCreated.Set();
        }

        public void OnSystemInitialized()
        {
            Dispatcher.BeginInvoke((Action)Close);
        }

        private void OnClosed(object sender, EventArgs e)
        {
            // This will gracefully shut down the splash screen
            //
            Dispatcher.InvokeShutdown();

            Loaded -= OnSplashLoaded;
            Closed -= OnClosed;
        }
    }
}
