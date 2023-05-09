using KeyboardLayoutSwapper.Keyboard;
using System.Windows;

namespace KeyboardLayoutSwapper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Hide();
            InitializeComponent();
            Hook.Start();
        }
    }
}
