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

        private  void TapGestureRecognizer_Tapped_For_SignUP(object sender, EventArgs e)
        {
            count++;
        }
    }

}
