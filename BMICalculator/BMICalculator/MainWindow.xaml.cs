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

namespace BMICalculator
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<BMIModificator> bmi { get; set; }

        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();

            bmi = new List<BMIModificator>();

            BMIModificator bmiMod1 = new BMIModificator();
            bmiMod1.Meaning = "Normal Weight";
            bmiMod1.BMI = "19-24.9";

            BMIModificator bmiMod2 = new BMIModificator();
            bmiMod2.Meaning = "Overweight";
            bmiMod2.BMI = "25-29.9";

            BMIModificator bmiMod3 = new BMIModificator();
            bmiMod3.Meaning = "Obesity I";
            bmiMod3.BMI = "30-34.9";

            BMIModificator bmiMod4 = new BMIModificator();
            bmiMod4.Meaning = "Obesity II";
            bmiMod4.BMI = "35-39.9";

            BMIModificator bmiMod5 = new BMIModificator();
            bmiMod5.Meaning = "Obesity III";
            bmiMod5.BMI = ">40";

            bmi.Add(bmiMod1);
            bmi.Add(bmiMod2);
            bmi.Add(bmiMod3);
            bmi.Add(bmiMod4);
            bmi.Add(bmiMod5);
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
