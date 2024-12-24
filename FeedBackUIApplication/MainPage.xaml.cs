using FeedBackUIApplication.Pages;
using SignInAndSignUpUI;

namespace FeedBackUIApplication
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void  ContinueClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FeedBackQuestions());
        }
    }

}
