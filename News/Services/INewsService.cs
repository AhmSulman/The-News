
/* Unmerged change from project 'News (net8.0-ios)'
Before:
using System;
After:
using News.Models;
using System;
*/

/* Unmerged change from project 'News (net8.0-windows10.0.19041.0)'
Before:
using System;
After:
using News.Models;
using System;
*/

/* Unmerged change from project 'News (net8.0-android)'
Before:
using System;
After:
using News.Models;
using System;
*/
using
/* Unmerged change from project 'News (net8.0-ios)'
Before:
using System.Threading.Tasks;
using News.Models;
After:
using System.Threading.Tasks;
*/

/* Unmerged change from project 'News (net8.0-windows10.0.19041.0)'
Before:
using System.Threading.Tasks;
using News.Models;
After:
using System.Threading.Tasks;
*/

/* Unmerged change from project 'News (net8.0-android)'
Before:
using System.Threading.Tasks;
using News.Models;
After:
using System.Threading.Tasks;
*/
News.Models;

namespace News.Services
{
    public interface INewsService
    {
        public Task<NewsResult> GetNews(NewsScope scope);
    }
}
