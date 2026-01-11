namespace NewsManagement.Models;
public class NewsArticle
{
    public DateTime? CreatedDate { get; set; }

    public string NewsArticleId { get; set; } = string.Empty;
    public string NewsTitle { get; set; } = string.Empty;
    public string Headline { get; set; } = string.Empty;

    public string NewsContent { get; set; } = string.Empty;
    public string NewsSource { get; set; } = string.Empty;
    public string CategoryID { get; set; } = string.Empty;
    public string NewsStatus { get; set; } = string.Empty;
    public string CreatedByID { get; set; } = string.Empty;
    public string UpdatedByID { get; set; } = string.Empty;
    public string ModifiedDate { get; set; } = string.Empty;

}
