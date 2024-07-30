using News.
/* Unmerged change from project 'News (net8.0-ios)'
Before:
using News.Views;
using System.Threading.Tasks;
using News.ViewModels;
using System.Linq;
After:
using News.ViewModels;
using News.Views;
using System.Linq;
using System.Threading.Tasks;
*/

/* Unmerged change from project 'News (net8.0-windows10.0.19041.0)'
Before:
using News.Views;
using System.Threading.Tasks;
using News.ViewModels;
using System.Linq;
After:
using News.ViewModels;
using News.Views;
using System.Linq;
using System.Threading.Tasks;
*/

/* Unmerged change from project 'News (net8.0-android)'
Before:
using News.Views;
using System.Threading.Tasks;
using News.ViewModels;
using System.Linq;
After:
using News.ViewModels;
using News.Views;
using System.Linq;
using System.Threading.Tasks;
*/
ViewModels;


namespace News.Views;

public partial class HeadlinesView : ContentPage
{
    readonly HeadlinesViewModel viewModel;
    public HeadlinesView(HeadlinesViewModel viewModel)
    {
        this.viewModel = viewModel;
        InitializeComponent();
        Task.Run(async () => await Initialize(GetScopeFromRoute()));
    }
    private async Task Initialize(string scope)
    {
        BindingContext = viewModel;
        await viewModel.Initialize(scope);
    }
    private string GetScopeFromRoute()
    {
        var route = Shell.Current.CurrentState.Location
        .OriginalString.Split("/").LastOrDefault();
        return route;
    }
}
