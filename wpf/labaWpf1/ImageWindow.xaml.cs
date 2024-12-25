using System.Windows;

namespace imageWindow
{
    public partial class ImageWindow : Window
    {
        public ImageWindow()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

