using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;

namespace LifeChoices.App.Content.Blog
{
    public class BlogDetailViewModel : BaseViewModel
    {
        public BlogItem BlogItem { get; }

        public string Source { get; }

        public BlogDetailViewModel(string id)
        {
            BlogItem = BlogStore.BlogItems.First(x => x.Id == id);
            Source = BlogItem.FullUri;
        } 
    }
}
