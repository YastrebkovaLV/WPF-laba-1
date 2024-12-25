using imageWindow;
using System.Windows;

namespace wpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenImageButton_Click(object sender, RoutedEventArgs e)
        {
            ImageWindow imageWindow = new ImageWindow();
            imageWindow.Show();
        }
    }
}
