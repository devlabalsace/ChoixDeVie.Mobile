using Xamarin.Forms;

namespace LifeChoices.App.Content.Scenarios.ProductDetails
{
    public partial class ProductDetailsPage : ContentPage
    {
        public ProductDetailsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            (BindingContext as ProductDetailsViewModel).SkeletonCommand.Execute(null);
        }
    }
}