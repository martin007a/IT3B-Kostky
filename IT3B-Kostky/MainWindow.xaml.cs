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


            for (int i = 1; i <= 3; i++)
            { 
                for (int j = 1; j <= 3; j++)
                {
                    Rectangle r = new Rectangle();

                    r.Width = can1.ActualWidth / 9;
                    r.Height = can1.ActualHeight / 9;
                    r.Fill = Brushes.Aqua;
                    r.Stroke = Brushes.Black;
                    r.StrokeThickness = 1;

                    Canvas.SetLeft(r, r.Width * j);
                    Canvas.SetTop(r, r.Height * i);
                    can1.Children.Add(r);
                }
            }
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Rectangle r = new Rectangle();

                    r.Width = can1.ActualWidth / 9;
                    r.Height = can1.ActualHeight / 9;
                    r.Fill = Brushes.Aqua;
                    r.Stroke = Brushes.Black;
                    r.StrokeThickness = 1;

                    Canvas.SetLeft(r, r.Width * j);
                    Canvas.SetTop(r, r.Height * i);
                    can2.Children.Add(r);
                }
            }
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Rectangle r = new Rectangle();

                    r.Width = can1.ActualWidth / 9;
                    r.Height = can1.ActualHeight / 9;
                    r.Fill = Brushes.Aqua;
                    r.Stroke = Brushes.Black;
                    r.StrokeThickness = 1;

                    Canvas.SetLeft(r, r.Width * j);
                    Canvas.SetTop(r, r.Height * i);
                    can3.Children.Add(r);
                }
            }
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Rectangle r = new Rectangle();

                    r.Width = can1.ActualWidth / 9;
                    r.Height = can1.ActualHeight / 9;
                    r.Fill = Brushes.Aqua;
                    r.Stroke = Brushes.Black;
                    r.StrokeThickness = 1;

                    Canvas.SetLeft(r, r.Width * j);
                    Canvas.SetTop(r, r.Height * i);
                    can4.Children.Add(r);
                }
            }
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Rectangle r = new Rectangle();

                    r.Width = can1.ActualWidth / 9;
                    r.Height = can1.ActualHeight / 9;
                    r.Fill = Brushes.Aqua;
                    r.Stroke = Brushes.Black;
                    r.StrokeThickness = 1;

                    Canvas.SetLeft(r, r.Width * j);
                    Canvas.SetTop(r, r.Height * i);
                    can5.Children.Add(r);
                }
            }
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Rectangle r = new Rectangle();

                    r.Width = can1.ActualWidth / 9;
                    r.Height = can1.ActualHeight / 9;
                    r.Fill = Brushes.Aqua;
                    r.Stroke = Brushes.Black;
                    r.StrokeThickness = 1;

                    Canvas.SetLeft(r, r.Width * j);
                    Canvas.SetTop(r, r.Height * i);
                    can6.Children.Add(r);
                }
            }
        }
    }
}