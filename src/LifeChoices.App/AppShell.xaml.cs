using Xamarin.Forms;
using LifeChoices.App.Content.Blog;
using LifeChoices.App.Content.Scenarios.Conversation;
using LifeChoices.App.Content.Scenarios.Login;
using LifeChoices.App.Content.Scenarios.ProductDetails;
using LifeChoices.App.Content.Scenarios.ToDo;
using LifeChoices.App.ControlGallery;
using LifeChoices.App.Scenarios;

namespace LifeChoices.App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute("control", typeof(ControlPage));
            Routing.RegisterRoute("map", typeof(MapPage));
            Routing.RegisterRoute("login", typeof(LoginPage));
            Routing.RegisterRoute("otherlogin", typeof(Content.Scenarios.OtherLogin.LoginPage));
            Routing.RegisterRoute("todo", typeof(ItemsPage));
            Routing.RegisterRoute("conversation", typeof(ConversationPage));
            Routing.RegisterRoute("productdetails", typeof(ProductDetailsPage));
            Routing.RegisterRoute("blog", typeof(BlogPage));
            Routing.RegisterRoute("blogDetail", typeof(BlogDetailPage));
        }
    }
}
