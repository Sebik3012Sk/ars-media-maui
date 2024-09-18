using ArsMediaApp.Database;
using System.Text.RegularExpressions;
using ArsMediaApp.Database.GET;


namespace ArsMediaApp.Pages;


public partial class LoginPage : ContentPage
{
    private Connection connection;
    private Regex matchEmailFormat;
    private Users usersObj;

	public LoginPage()
	{
		InitializeComponent();
        connection = new Connection();
        usersObj = new Users();
	}

    private async void loginBtClicked(object sender, EventArgs e)
    {
        var users_data = usersObj.GetUsers();

        string inputEmail = email_entry.Text.ToString().ToLower();
        string inputPassword = password_entry.Text.ToLower();

        foreach (var user in users_data)
        {
            if (user["email"] == inputEmail && user["password"] == inputPassword)
            {
                await Navigation.PushAsync(new MainPage());
            }
        }
        
            
    }
}