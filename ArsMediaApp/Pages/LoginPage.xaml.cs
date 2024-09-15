namespace ArsMediaApp.Pages;
using ArsMediaApp.Database;

public partial class LoginPage : ContentPage
{
    private Connection connection; 

	public LoginPage()
	{
		InitializeComponent();
        connection = new Connection();
	}

    private async void loginBtClicked(object sender, EventArgs e)
    {
        var users_data = connection.connectDb("http://localhost:57257/get-data");
        bool user_found = false;
        foreach (var user in users_data)
        {
            if (user["email"] == email_entry.Text && user["password"] == password_entry.Text)
            {
                user_found = true;
                //redirect to post page
            }
        }
        if(!user_found)
            await DisplayAlert("Incorrect", "Email or password are incorrect", "Ok");
    }
}