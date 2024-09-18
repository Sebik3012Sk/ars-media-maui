using ArsMediaApp.Pages;
using ArsMediaApp.Models;

namespace ArsMediaApp
{
    public partial class AppShell : Shell
    {

        public AppShell(User user = null)
        {
            InitializeComponent();
            BindingContext = this;
        }

        private async void Logout_Event(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
