using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormsDesignMode
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            if (DesignTimeHelper.DesignModeOn)
            {
                DescriptionLabel.Text = "Code was executed.";
            }
        }
    }
}
