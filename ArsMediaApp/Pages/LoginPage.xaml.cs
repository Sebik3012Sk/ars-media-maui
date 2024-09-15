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
        var users_data = connection.connectDb("http://localhost:59056/get-data");
        foreach (var user in users_data)
        {
            if (user["email"] == email_entry.Text && user["password"] == password_entry.Text)
            {
                //redirect to post page
            }
        }
        await DisplayAlert("Incorrect", "Email or password are incorrect", "Ok");
    }
}