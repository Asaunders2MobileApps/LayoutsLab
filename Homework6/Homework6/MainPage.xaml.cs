using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Homework6
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        async void SharedResourceNav(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SharedResource());
        }

        async void StaticMarkupNav(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new StaticMarkup());
        }

        async void SliderNav(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Slider());
        }
    }
}
