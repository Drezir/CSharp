using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Sum SumObj { get; set; }

        public int MyProperty
        {
            get { return (int)GetValue(dependencyProperty); }
            set { SetValue(dependencyProperty, value); }
        }
        public static readonly DependencyProperty dependencyProperty =
            DependencyProperty.Register("My Property", typeof(int), typeof(MainWindow), new PropertyMetadata(0));

        public MainWindow()
        {
            InitializeComponent();
            /*
            Grid grid = new Grid();
            this.Content = grid;
            */

            // bubble vs TUNNEL events
            secondButton.PreviewMouseUp += SecondButton_MouseUp;

            SumObj = new Sum { Num1 = "1", Num2 = "2" };
            this.DataContext = SumObj;
        }

        private void FirstButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World", "Hello World", MessageBoxButton.OK);
        }

        private void SecondButton_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Second button clicked", "Event raised", MessageBoxButton.OK);
        }
    }
}
