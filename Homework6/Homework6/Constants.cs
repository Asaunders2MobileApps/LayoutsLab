using System;
using Xamarin.Forms;

namespace Homework6
{
    class Constants
    {
        public static readonly Thickness PagePadding;

        public static readonly Font TitleFont;
        
        public static readonly Color BackgroundColor = Color.Black;

        public static readonly Color BackgroundColor2 = Color.Red;

        public static readonly Color BackgroundColor3 = Color.Green;

        public static readonly Color ForegroundColor = Color.Aqua;

        static Constants()
        {
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    PagePadding = new Thickness(5, 20, 5, 0);
                    TitleFont = Font.SystemFontOfSize(30, FontAttributes.Italic);
                    break;

                case Device.Android:
                    PagePadding = new Thickness(5, 5, 5, 5);
                    TitleFont = Font.SystemFontOfSize(33, FontAttributes.Bold);
                    break;

                case Device.UWP:
                    PagePadding = new Thickness(15, 10, 15, 10);
                    TitleFont = Font.SystemFontOfSize(42, FontAttributes.None);
                    break;
            }
        }

    }
}
