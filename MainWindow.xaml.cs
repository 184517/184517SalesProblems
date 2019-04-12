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

namespace _184517SalesProblem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] MonthData = new string[13];
        int months;
        System.IO.StreamReader sr = new System.IO.StreamReader("2018.txt");
        public MainWindow()
        {
            InitializeComponent();

            ReadData();
        }

        private void ReadData()
        {
            if (txtInput.Text.Contains("2017"))
            {
                try
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader("2017.txt");
                    int i = 0;
                    while (!sr.EndOfStream)
                    {
                        MonthData[i] = sr.ReadLine();
                        i++;

                    }//end while
                    sr.Close();
                } //end try

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }//end catch
            }

            if (txtInput.Text.Contains("2018"))
            {
                try
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader("2018.txt");
                    int i = 0;
                    while (!sr.EndOfStream)
                    {
                        MonthData[i] = sr.ReadLine();
                        i++;
                    }//end while
                    sr.Close();
                } //end try

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }//end catch
            }
        }

        private void btnJanuary_Click(object sender, RoutedEventArgs e)
        {
            ReadData();
            months = 1;
            lblOutput.Content = MonthData[months];
        }

        private void btnFebruary_Click(object sender, RoutedEventArgs e)
        {
            ReadData();
            months = 2;
            lblOutput.Content = MonthData[months];

        }

        private void btnMarch_Click(object sender, RoutedEventArgs e)
        {
            ReadData();
            months = 3;
            lblOutput.Content = MonthData[months];

        }

        private void btnApril_Click(object sender, RoutedEventArgs e)
        {
            ReadData();
            months = 4;
            lblOutput.Content = MonthData[months];

        }

        private void btnMay_Click(object sender, RoutedEventArgs e)
        {
            ReadData();
            months = 5;
            lblOutput.Content = MonthData[months];
        }

        private void btnJune_Click(object sender, RoutedEventArgs e)
        {
            ReadData();
            months = 6;
            lblOutput.Content = MonthData[months];

        }

        private void btnJuly_Click(object sender, RoutedEventArgs e)
        {
            ReadData();
            months = 7;
            lblOutput.Content = MonthData[months];
        }

        private void btnAugust_Click(object sender, RoutedEventArgs e)
        {
            ReadData();
            months = 8;
            lblOutput.Content = MonthData[months];
        }

        private void btnSeptember_Click(object sender, RoutedEventArgs e)
        {
            ReadData();
            months = 9;
            lblOutput.Content = MonthData[months];
        }

        private void btnOctober_Click(object sender, RoutedEventArgs e)
        {
            ReadData();
            months = 10;
            lblOutput.Content = MonthData[months];
        }

        private void btnNovember_Click(object sender, RoutedEventArgs e)
        {
            ReadData();
            months = 11;
            lblOutput.Content = MonthData[months];
        }

        private void btnDecember_Click(object sender, RoutedEventArgs e)
        {
            ReadData();
            months = 12;
            lblOutput.Content = MonthData[months];
        }

       


    }
}
