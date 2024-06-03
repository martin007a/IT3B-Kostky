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

namespace IT3B_Kostky
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Dice dice1 = new Dice();
            Dice dice2 = new Dice();
            Dice dice3 = new Dice();
            Dice dice4 = new Dice();
            Dice dice5 = new Dice();
            Dice dice6 = new Dice();

            lab1.Content = dice1.Hodit.ToString();
            lab2.Content = dice2.Hodit.ToString();
            lab3.Content = dice3.Hodit.ToString();
            lab4.Content = dice4.Hodit.ToString();
            lab5.Content = dice5.Hodit.ToString();
            lab6.Content = dice6.Hodit.ToString();
        }
    }
}