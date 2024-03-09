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

namespace BasiCalc
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

        private void Btn_ChangeTXT_Click(object sender, RoutedEventArgs e)
        {
            TXT_Box.Text = "it changed yay";

        }

        private void Btn_AddTXT_Click(object sender, RoutedEventArgs e)
        {
            TXT_Box.Text += " <-- the fist part is a lie";
        }

        private void TXT_Box_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}