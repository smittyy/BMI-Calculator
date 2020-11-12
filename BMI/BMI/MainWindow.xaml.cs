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

namespace BMI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public partial class Customer: Window
        {
            public string lastName { get; set; }
            public string firstName { get; set; }
            public string phoneNumber { get; set; }
            public int heightInches { get; set; }
            public int weightLbs { get; set; }
            public int custBMI { get; set; }
            public string statusTitle { get; set; }

        }

        public MainWindow()
        {
            InitializeComponent();
        }



        #region clear and exit button
        public void ClearBTN_Click(object sender, RoutedEventArgs e)
        {
            xPhoneBox.Text = "";
            xFirstNameBox.Text = "";
            xLastNameBox.Text = "";
            xHeightInchesBox.Text = "";
            xWeightLbsBox.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            int bmi;
            string CustomerBMIStatus = "NA";

            Customer NewCustomer = new Customer();

            NewCustomer.lastName = xFirstNameBox.Text;
            NewCustomer.firstName = xFirstNameBox.Text;
            NewCustomer.phoneNumber = xPhoneBox.Text;

            NewCustomer.heightInches = Convert.ToInt32(xHeightInchesBox.Text);
            NewCustomer.weightLbs = Convert.ToInt32(xWeightLbsBox.Text);

            bmi = 703 * NewCustomer.weightLbs / (NewCustomer.heightInches * NewCustomer.heightInches);
            //OutputBox.Text = Convert.ToString(bmi);

            NewCustomer.statusTitle = CustomerBMIStatus;
            xYourBMIResults.Text = Convert.ToString(bmi);
            if (bmi < 18.5)
            {
                xBMIMessage.Text = "According to CDC.gov BMI Calculator you are underweight.";
                NewCustomer.statusTitle = "Underweight";
            }else if (bmi < 24.9)
            {
                xBMIMessage.Text = "According to CDC.gov BMI Calculator you have a normal body weight.";
                NewCustomer.statusTitle = "Normal";
            }else if (bmi < 29.9)
            {
                xBMIMessage.Text = "According to CDC.gov BMI Calculator you are overweight.";
                NewCustomer.statusTitle = "Overweight";
            }else
            {
                xBMIMessage.Text = "According to CDC.gov BMI Calculator you are obese.";
                NewCustomer.statusTitle = "Obese";
            }


        }
    }
}
