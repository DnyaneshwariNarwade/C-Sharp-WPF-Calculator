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


namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double n1 = 0;
        private double n2 = 0;
        string op = null;
        double Rs = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {

            if (op == null)
            {

                n1 = n1 * 10 + 1;
                txtn1.Text = n1.ToString();
            }
            else
            {
                n2 = n2 * 10 + 1;
                txtn2.Text = n2.ToString();
            }

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (op == null)
            {

                n1 = n1 * 10 + 2;
                txtn1.Text = n1.ToString();
            }
            else
            {
                n2 = n2 * 10 + 2;
                txtn2.Text = n2.ToString();
            }

        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (op == null)
            {

                n1 = n1 * 10 + 3;
                txtn1.Text = n1.ToString();
            }
            else
            {
                n2 = n2 * 10 + 3;
                txtn2.Text = n2.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (op == null)
            {
                
                n1 = n1 * 10 + 7;
                txtn1.Text = n1.ToString();
            }
            else
            {
                n2 = n2 * 10 + 7;
                txtn2.Text = n2.ToString();
            }

        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (op == null )
            {

                n1 = n1 * 10 + 9;
                txtn1.Text = n1.ToString();
            }
            else
            {
                n2 = n2 * 10 + 9;
                txtn2.Text = n2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (op == null)
            {

                n1 = n1 * 10 + 5;
                txtn1.Text = n1.ToString();
            }
            else
            {
                n2 = n2 * 10 + 5;
                txtn2.Text = n2.ToString();
            }
        }
            private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (op == null)
            {

                n1 = n1 * 10 + 6;
                txtn1.Text = n1.ToString();
            }
            else
            {
                n2 = n2 * 10 + 6;
                txtn2.Text = n2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (op == null)
            {

                n1 = n1 * 10 + 8;
                txtn1.Text = n1.ToString();
            }
            else
            {
                n2 = n2 * 10 + 8;
                txtn2.Text = n2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
           
                if (op == null)
                {

                    n1 = n1 * 10 + 4;
                    txtn1.Text = n1.ToString();
                }
                else
                {
                    n2 = n2 * 10 + 4;
                    txtn2.Text = n2.ToString();
                }
        }
        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (op == null)
            {

                n1 = n1 * 10 + 0;
                txtn1.Text = n1.ToString();
            }
            else
            {
                n2 = n2 * 10 + 0;
                txtn2.Text = n2.ToString();
            }
        }

        private void btnplus_Click(object sender, RoutedEventArgs e)
        {
           
            {
              
                {
                    op = "+";
                    txtop.Text = "+";
                    // btnplus.Visibility = Visibility.Collapsed;
                }
            }


        }

        private void btnresult_Click(object sender, RoutedEventArgs e)
        {
            
            if (txtn2.Text != "")
            {
                txtn1.Clear();
                txtn2.Clear();
                txtop.Clear();
                switch (op)
                {
                    case "+":
                        {

                            {
                                Rs = n1 + n2;
                                n1 = Rs;
                                txtn1.Text = Rs.ToString();
                                n2 = 0;
                            }


                            break;
                        }
                    case "-":
                        {
                            Rs = n1 - n2;
                            n1 = Rs;
                            txtn1.Text = Rs.ToString();
                            n2 = 0;
                            break;
                        }
                    case "*":
                        {
                            Rs = n1 * n2;
                            n1 = Rs;
                            txtn1.Text = Rs.ToString();
                            n2 = 0;
                            break;
                        }
                    case "/":
                        {
                            Rs = n1 / n2;
                            n1 = Rs;
                            txtn1.Text = Rs.ToString();
                            n2 = 0;
                            break;
                        }
                    case "%":
                        {
                            Rs = n1%n2;
                            n1 = Rs;
                            txtn1.Text = Rs.ToString();
                            n2 = 0;
                            break;
                        }
                    case "√":
                        {
                           
                            break;
                        }
                    case "^":
                        {
                            Rs = Math.Pow(n1, n2);
                            n1 = Rs;
                            txtn1.Text = n1.ToString();
                            break;
                        }
                    case "cos":
                        {
                            if (string.IsNullOrEmpty(txtn1.Text))
                            {
                                
                                n1 = 0;
                                Rs = Math.Cos(n2);
                                n1 = Rs;
                                txtn1.Text = n1.ToString();
                                n2 = 0;
                               
                            }
                            break;
                        }
                    case "sin":
                        {
                            if (string.IsNullOrEmpty(txtn1.Text))
                            {

                                n1 = 0;
                                Rs = Math.Sin(n2);
                                n1 = Rs;
                                txtn1.Text = n1.ToString();
                                n2 = 0;

                            }
                            break;

                        }
                    case "tan":
                        {
                            if (string.IsNullOrEmpty(txtn1.Text))
                            {

                                n1 = 0;
                                Rs = Math.Tan(n2);
                                n1 = Rs;
                                txtn1.Text = n1.ToString();
                                n2 = 0;
                                

                            }
                            break;
                        }
                    case "ln":
                        {
                            if (string.IsNullOrEmpty(txtn1.Text))
                            {
                                n1 = 0;
                                Rs = Math.Log(n2);
                                n1 = Rs;
                                txtn1.Text = n1.ToString();
                                n2 = 0;
                            }
                            break;

                        }
                    case "log":
                        {
                            if (string.IsNullOrEmpty(txtn1.Text))
                            {
                                n1 = 0;
                                Rs = Math.Log10(n2);
                                n1 = Rs;
                                txtn1.Text = n1.ToString();
                                n2 = 0;
                            }
                            break;
                        }

                    case "null":
                        {
                            break;
                        }
                }
            }
        }

  

        private void btnminus_Click (object sender, RoutedEventArgs e)
        {
          
            {
                op = "-";
                txtop.Text = "-";
            }
           

        }

        private void btnmul_Click(object sender, RoutedEventArgs e)
        {
            op = "*";
            txtop.Text = "*";

        }

        private void btndidivide_Click(object sender, RoutedEventArgs e)
        {
            op = "/";
            txtop.Text = "/";

        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtn2.Text))
            {
                txtn2.Text = "";
                n2 = 0;
            }
            else if (!string.IsNullOrEmpty(txtop.Text))
            {
                txtop.Text = "";
                op = null;
            }
            else
            {
                txtn1.Text = "";
                n1 = 0;
               
            }
            
        }

        private void btndelete_Click(object sender, RoutedEventArgs e)
        {
            txtop.Text = "";
            txtn1.Text = "";
            txtn2.Text = "";
            n1 = 0;
            n2 = 0;
            op = null;
            txtn1.Text = "0";
            n1 = 0;

        }

        private void btnremender_Click(object sender, RoutedEventArgs e)
        {
            op = "%";
            txtop.Text = "%";
        }

        private void btnsqrt_Click(object sender, RoutedEventArgs e)
        {
            op = "√";
            Rs = Math.Sqrt(n1);
            n1 = Rs;
            txtn1.Text = Rs.ToString();
            n2 = 0;
        }

        private void btnpi_Click(object sender, RoutedEventArgs e)
        {
            
            if(string.IsNullOrEmpty(txtn1.Text))
            {
                
                Rs = Math.PI;
                n1 = Rs;
                txtn1.Text = n1.ToString();
            }
            else if (string.IsNullOrEmpty(txtop.Text) && txtn1.Text !="3.141592653589793")
            {
                Rs = Math.PI * n1;
                n1 = Rs;
                txtn1.Text = n1.ToString();
            }
            else if(string.IsNullOrEmpty(txtn2.Text)&& txtop.Text!= "3.141592653589793" +
                "" || txtn1.Text != "3.141592653589793")
            {
                n2 = Math.PI;
                txtn2.Text = n1.ToString();
            }
        }

        private void btndenominator_Click(object sender, RoutedEventArgs e)
        {
            if(txtn1.Text=="")
            {
                txtn1.Text = "1";
                n1 = 1;
            }
            else 
            {
                n1 =1;
                Rs = n1;
                txtn1.Text =n1.ToString();
               
            }
            
            
           
            op = "/";
            txtop.Text = "/";
        }

        private void btnExponential_Click(object sender, RoutedEventArgs e)
        {

            if (txtn1.Text != "")
            {
                op = "^";
                txtop.Text = "^";
            } 
           
        }

        private void btncos_Click(object sender, RoutedEventArgs e)
        {

            txtop.Text = "cos";
            op = "cos";
            

        }

        private void btnsin_Click(object sender, RoutedEventArgs e)
        {
            n1 = 0;
            txtop.Text = "sin";
            op = "sin";

        }

        private void btntan_Click(object sender, RoutedEventArgs e)
        {
            n1 = 0;
            txtop.Text = "tan";
            op = "tan";
        }

        private void btnfactorial_Click(object sender, RoutedEventArgs e)
        {
            Rs = 1;
            op = "!";
            while (n1 != 0)
            {
                Rs = Rs * n1;
                n1 = n1 - 1;
            }
            n1 = Rs;
            op =null;
            txtn1.Text = n1.ToString();
        }

        private void btnexpo_Click(object sender, RoutedEventArgs e)
        {
            if(n1!=0 && op==null)
            {
                op = "";
                Rs = Math.Exp(n1);
                n1 = Rs;
                txtn1.Text = n1.ToString();
            }
            else
            {

            }
           
        }

        private void ln10_Click(object sender, RoutedEventArgs e)
        {
            n1 = 0;
            txtop.Text="ln";
            op = "ln";
        
        }

        private void btnlog_Click(object sender, RoutedEventArgs e)
        {
            op = "log";
            txtop.Text = "log";
        }
    }
}
