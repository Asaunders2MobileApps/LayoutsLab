using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Homework6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SharedResource : ContentPage
    {
        public SharedResource()
        {
            InitializeComponent();
        }

        private void Add(object sender, EventArgs e)
        {
            var num1 = Convert.ToDouble(iNum1.Text);
            var num2 = Convert.ToDouble(iNum2.Text);
            oOutput.Text = num1.ToString() + " + " + num2.ToString() + " = " + (num1+num2).ToString();
        }

        private void Subtract(object sender, EventArgs e)
        {
            var num1 = Convert.ToDouble(iNum1.Text);
            var num2 = Convert.ToDouble(iNum2.Text);
            oOutput.Text = num1.ToString() + " - " + num2.ToString() + " = " + (num1 - num2).ToString();
        }

        private void Multiply(object sender, EventArgs e)
        {
            var num1 = Convert.ToDouble(iNum1.Text);
            var num2 = Convert.ToDouble(iNum2.Text);
            oOutput.Text = num1.ToString() + " * " + num2.ToString() + " = " + (num1 * num2).ToString();
        }
    }
}