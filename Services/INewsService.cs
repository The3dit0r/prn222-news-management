using NewsManagement.Models;
namespace NewsManagement.Services;
public interface INewsService
{
    public List<NewsArticle> GetAllNews();

    public List<NewsArticle> SearchForNews();

    public List<NewsArticle> GetNewsByCategory(int categoryId);

    public List<NewsArticle> GetNewsByAuthor(int authorId);
}
