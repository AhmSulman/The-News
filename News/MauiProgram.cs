/* Unmerged change from project 'News (net8.0-ios)'
Before:
using Microsoft.Extensions.Configuration;
using Microsoft.Maui;
using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Media;
using CommunityToolkit.Maui;
After:
using Microsoft.Maui;
using CommunityToolkit.Maui.Media;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Maui;
*/

/* Unmerged change from project 'News (net8.0-windows10.0.19041.0)'
Before:
using Microsoft.Extensions.Configuration;
using Microsoft.Maui;
using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Media;
using CommunityToolkit.Maui;
After:
using Microsoft.Maui;
using CommunityToolkit.Maui.Media;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Maui;
*/

/* Unmerged change from project 'News (net8.0-android)'
Before:
using Microsoft.Extensions.Configuration;
using Microsoft.Maui;
using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Media;
using CommunityToolkit.Maui;
After:
using Microsoft.Maui;
using CommunityToolkit.Maui.Media;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Maui;
*/
/* Unmerged change from project 'News (net8.0-ios)'
Before:
using CommunityToolkit.Extensions.Logging;
After:
using CommunityToolkit.Extensions.Logging;
using CommunityToolkit.Maui;
*/

/* Unmerged change from project 'News (net8.0-windows10.0.19041.0)'
Before:
using CommunityToolkit.Extensions.Logging;
After:
using CommunityToolkit.Extensions.Logging;
using CommunityToolkit.Maui;
*/

/* Unmerged change from project 'News (net8.0-android)'
Before:
using CommunityToolkit.Extensions.Logging;
After:
using CommunityToolkit.Extensions.Logging;
using CommunityToolkit.Maui;
*/


using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui.Media;

namespace News
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Font-Brand-Regular-400", "Font-Awesome.otf");
                fonts.AddFont("FontAwesome-Regular-400", "FontAwesome-Regular-400.otf");
                fonts.AddFont("FontAwsome-Solid-900", "FontAwsome-Solid-900.otf");

            }).UseMauiCommunityToolkit().UseMauiCommunityToolkitMediaElement().RegisterAppTypes();
#if DEBUG
            builder.Logging.AddDebug();
#endif
            return builder.Build();
        }
        public static MauiAppBuilder RegisterAppTypes(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<Services.INewsService>((ServiceProvider) => new Services.NewsService());
            mauiAppBuilder.Services.AddSingleton<ViewModels.INavigate>((serviceProvider) => new Navigator());
            mauiAppBuilder.Services.AddTransient<ViewModels.HeadlinesViewModel>();
            mauiAppBuilder.Services.AddTransient<Views.AboutView>();
            mauiAppBuilder.Services.AddTransient<Views.ArticleView>();
            return mauiAppBuilder;

        }
    }

}