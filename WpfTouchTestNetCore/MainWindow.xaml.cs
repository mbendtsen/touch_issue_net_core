using System.Windows;

namespace WpfScrollTestNetCore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindowViewModel Context => DataContext as MainWindowViewModel;

        public MainWindow()
        {
            InitializeComponent();

            PreviewMouseDown += (s, e) => { Context.AddEvent($"PreviewMouseDown {e.OriginalSource.GetType().Name}"); };
            PreviewTouchDown += (s, e) => { Context.AddEvent($"PreviewTouchDown {e.OriginalSource.GetType().Name}"); };
        }

        private void ScrollViewer_ManipulationBoundaryFeedback(object sender, System.Windows.Input.ManipulationBoundaryFeedbackEventArgs e)
        {
            e.Handled = true;
        }
    }
}
