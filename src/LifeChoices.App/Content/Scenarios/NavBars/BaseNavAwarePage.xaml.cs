using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LifeChoices.App.Content.Scenarios.NavBars
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BaseNavAwarePage : ContentPage
    {
        public BaseNavAwarePage()
        {
            InitializeComponent();
        }
    }
}