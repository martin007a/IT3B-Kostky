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

            int m = 0;

            Dice[] dices = { dice1, dice2, dice3, dice4, dice5, dice6 };

            Canvas[] cans = { can1, can2, can3, can4, can5, can6 };
             
            foreach(Canvas c in cans ) 
            {
               // MessageBox.Show(dices[m].Hodit.ToString());
                c.Children.Clear();

                for (int i = 0; i <= 2; i++)
                {
                    for (int j = 0; j <= 2; j++)
                    {
                        Ellipse r = new Ellipse();

                        r.Width = can1.ActualWidth / 3;
                        r.Height = can1.ActualHeight / 3;

                        
                        switch (dices[m].Hodit)
                        {
                            case 1:
                                if (j ==1  && i==1)
                                {
                                    r.Fill = Brushes.Black;
                                    r.Stroke = Brushes.Wheat;
                                }
                                else
                                {
                                    r.Fill = Brushes.Wheat;
                                }
                                break;
                            case 2:
                                if ((j == 0 && i == 0) || (j == 2 && i == 2))
                                {
                                    r.Fill = Brushes.Black;
                                    r.Stroke = Brushes.Wheat;
                                }
                                else
                                {
                                    r.Fill = Brushes.Wheat;
                                }
                                break;
                            case 3:
                                if (i == j)
                                {
                                    r.Fill = Brushes.Black;
                                    r.Stroke = Brushes.Wheat;
                                }
                                else
                                {
                                    r.Fill = Brushes.Wheat;
                                }
                                break;
                            case 4:
                                if ((i == 0 || i == 3 - 1) && (j == 0 || j == 3 - 1))
                                {
                                    r.Fill = Brushes.Black;
                                    r.Stroke = Brushes.Wheat;
                                }
                                else
                                {
                                    r.Fill = Brushes.Wheat;
                                }
                                break;
                            case 5:
                                if ((i == j) || (Math.Abs(i - j)== 2))
                                {
                                    r.Fill = Brushes.Black;
                                    r.Stroke = Brushes.Wheat;
                                }
                                else
                                {
                                    r.Fill = Brushes.Wheat;
                                }
                                break;
                            case 6:
                                if (j == 0 || j == 2)
                                {
                                    r.Fill = Brushes.Black;
                                    r.Stroke = Brushes.Wheat;
                                }
                                else
                                {
                                    r.Fill = Brushes.Wheat;
                                }
                                r.StrokeThickness = 1;
                                break;
                        }
                        Canvas.SetLeft(r, r.Width * j);
                        Canvas.SetTop(r, r.Height * i);
                        c.Children.Add(r);
                    }
                }
                m++;
            }

        }
    }
}