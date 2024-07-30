
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Maui;
using System.Web;
using News.Services;
using News.Models;
using News.ViewModels;
using CommunityToolkit.Mvvm.Input;

namespace News.ViewModels
{
    public partial class HeadlinesViewModel : ViewModel
    {

        private readonly INewsService newsService;
        [ObservableProperty]
        private NewsResult currentNews;

        public HeadlinesViewModel(INewsService newsService, INavigate navigation) : base(navigation)
        {
            this.newsService = newsService;
        }
        public async Task Initialize(string scope)
        =>
        await Initialize(scope.ToLower()
        switch
        {
            "local" => NewsScope.Local,
            "global" => NewsScope.Global,
            "headlines" =>
    NewsScope.Headlines,
            _ => NewsScope.Headlines
        });
        public async Task Initialize(NewsScope
        scope)
        {
            CurrentNews = await
            newsService.GetNews(scope);
        }
        [RelayCommand]
        public async Task ItemSelected(object
        selectedItem)
        {
            var selectedArticle = selectedItem as
            Article;
            var url =
            HttpUtility.UrlEncode(selectedArticle.Url);
            // Placeholder for more code later on
            await Navigation.NavigateTo($"articleview?url={url}");
        }
    }
}
