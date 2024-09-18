namespace ArsMediaApp.Controllers;
using ArsMediaApp.Database;
using ArsMediaApp.Models;
using System.Collections.ObjectModel;
using ArsMediaApp.Pages;
using ArsMediaApp.Database.GET;

public partial class LIstPost : ContentView
{
    private ObservableCollection<Post> posts;
    private Connection connection;
    private Posts postsObj;


    public LIstPost()
	{
		InitializeComponent();
        posts = new ObservableCollection<Post>();
        connection = new Connection();
        postsObj = new Posts();
        listView_posts.ItemsSource = posts;
    }


    private void LoadContent_Event(object sender, EventArgs e)
    {
        posts.Clear();
        var data_posts = postsObj.GetPosts();
        foreach (var post in data_posts)
        {
            posts.Add(new Post
            {
                PostName = post["post_name"].ToString(),
                PostContent = post["post_content"].ToString(),
                Likes = post["likes"],
                Description = post["description"].ToString(),
                ImageSource = post["image"]
            });
        }
    }

    private async void SelectedPost_Event(object sender, SelectedItemChangedEventArgs e)
    {
        var selectedPost = e.SelectedItem as Post;

        if(selectedPost != null)
        {
            await Navigation.PushAsync(new PostDetail(selectedPost));
        }
    }
}