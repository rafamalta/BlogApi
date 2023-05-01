using BlogApi.Models;

namespace BlogApi.ViewModels.Posts;

public class CountPostsViewModel
{
    public int Count { get; set; }
    public int Page { get; set; }
    public int PageSize { get; set; }
    public List<ListPostsViewModel> Posts { get; set; }

}

