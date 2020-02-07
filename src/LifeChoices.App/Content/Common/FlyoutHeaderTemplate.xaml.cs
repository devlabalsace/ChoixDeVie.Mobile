using System;
using System.Collections.Generic;

using Xamarin.Forms;
using LifeChoices.App.Content.Settings;

namespace LifeChoices.App.Content.Common
{
    public partial class FlyoutHeaderTemplate : Grid
    {
        public FlyoutHeaderTemplate()
        {
            InitializeComponent();

        }

        async void Handle_Tapped(object sender, System.EventArgs e)
        {
            await Shell.Current.Navigation.PushModalAsync(new SettingsPage(), true);
        }
    }
}
