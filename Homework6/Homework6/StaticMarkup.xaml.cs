﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Homework6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StaticMarkup : ContentPage
    {
        public StaticMarkup()
        {
            InitializeComponent();
        }

        private async void ScrollToTop(object sender, EventArgs e) => await ScrollArea.ScrollToAsync(0, 0, true);
    }
}