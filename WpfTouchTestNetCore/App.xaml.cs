using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace WpfScrollTestNetCore
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private SplashViewModel _splashViewModel;
        private Thread _splashThread;

        protected async override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ShowSplash();

            await Task.Delay(2000);

            _splashViewModel.SetInitialized();

            var window = new MainWindow()
            {
                DataContext = new MainWindowViewModel()
            };
            window.Show();
            MainWindow = window;
        }

        private void ShowSplash()
        {
            _splashViewModel = new SplashViewModel();

            _splashThread = new Thread(() =>
            {
                new Splash { DataContext = _splashViewModel }.Show();
                Dispatcher.Run();
            });
            _splashThread.SetApartmentState(ApartmentState.STA);
            _splashThread.IsBackground = true;
            _splashThread.Name = "Splash";
            _splashThread.Start();

            _splashViewModel.SplashCreated.WaitOne();
        }
    }
}
