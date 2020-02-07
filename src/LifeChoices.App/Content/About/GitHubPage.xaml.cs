
using Xamarin.Forms;
using LifeChoices.App.About.ViewModels;

namespace LifeChoices.App.About
{
    public partial class GitHubPage : ContentPage
    {
        public GitHubPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            ContributorsCollectionView.SelectedItem = null;
            await ((GitHubViewModel)BindingContext).OnAppearing();
        }
    }
}