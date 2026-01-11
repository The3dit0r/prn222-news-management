using NewsManagement.Models;
using Newtonsoft.Json;

namespace NewsManagement.TestData;
public static class TestData
{
    public static List<NewsArticle>? GetAllNews()
    {
        using StreamReader r = new("./TestData/test_news.json");
        var rawData = r.ReadToEnd();
        var deserialized = JsonConvert.DeserializeObject<List<NewsArticle>>(rawData);

        return deserialized;
    }
}
