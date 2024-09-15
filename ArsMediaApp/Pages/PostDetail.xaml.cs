using ArsMediaApp.Models;

namespace ArsMediaApp.Pages;

public partial class PostDetail : ContentPage
{
	public PostDetail(Post selectedPost)
	{
		InitializeComponent();
		BindingContext = selectedPost;
	}
}