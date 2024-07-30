using System.Web;

namespace News.Views;

[QueryProperty("Url", "url")]
public partial class ArticleView : ContentPage
{
    // Property to set the URL
    public string Url
    {
        set
        {
            // Setting the BindingContext
            BindingContext = new UrlWebViewSource
            {
                Url = HttpUtility.UrlDecode(value)
            };
        }
    }

    // Constructor
    public ArticleView()
    {
        InitializeComponent();
    }
}
