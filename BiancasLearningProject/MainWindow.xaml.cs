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

namespace BiancasLearningProject
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

        private void CalculateResult(object sender, RoutedEventArgs e)
        {
            string value1 = valueOneTextBox.Text;
            string value2 = valueTwoTextBox.Text;

            if (!int.TryParse(value1, out int value1Int))
            {
                MessageBox.Show("Es kann nicht konvertiert werden!");
            }
            if (!int.TryParse(value2, out int value2Int))
            {
                MessageBox.Show("Es kann nicht konvertiert werden!");
            }
            int result = value1Int + value2Int;

            resultLabel.Content = result;
        }
    }
}