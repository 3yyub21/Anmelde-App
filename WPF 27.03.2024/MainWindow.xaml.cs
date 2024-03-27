using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_27._03._2024
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Anmelden_Click(object sender, RoutedEventArgs e)
        {
           string text = VornameBox.Text + " " + NachnameBox.Text;
           AnmeldenLabel.Content = text;
        }

        private void Löschen_Click(object sender, RoutedEventArgs e)
        {
            VornameBox.Text = "";
            NachnameBox.Clear();
            AnmeldenLabel.Content = "";
        }
    }
}