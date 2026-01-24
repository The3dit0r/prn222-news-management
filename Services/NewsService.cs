using Microsoft.EntityFrameworkCore;
using NewsManagement.Models;
using NewsManagement.DataAccess;

namespace NewsManagement.Services;

public class NewsService : INewsService
{
    readonly NewsAppContext db;

    public NewsService(NewsAppContext context)
    {
        db = context;
    }

    public List<NewsArticle> GetAllNews()
    {
        var newsList = (from NewsArticles in db.NewsArticles
                        select NewsArticles).ToList();

        return newsList;
    }

    public List<NewsArticle> GetNewsByAuthor(int authorId)
    {
        var newsList = (from article in db.NewsArticles
                        where article.CreatedById == authorId
                        select article).ToList();

        return newsList;
    }

    public List<NewsArticle> GetNewsByCategory(int catId)
    {
        var newsList = (from article in db.NewsArticles
                        where article.CategoryId == catId
                        select article).ToList();

        return newsList;
    }
    public List<NewsArticle> SearchForNews()
    {
        throw new NotImplementedException();
    }
}
