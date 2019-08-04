using Models;
using BlogTest.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogTest.Services.Interfaces
{
    public interface IBlogService
    {
		Task<Page<PostLiteViewModel>> GetPosts(int pageIndex, string tag);
		Task<Post> GetPost(int postId);
		Task AddComment(AddCommentRequest request);
		Task AddPost(AddPostRequest request);
	    Task DeletePost(int postId);
	    Task DeleteComment(int commentId);
		Task<List<string>> GetTags();
	}
}
