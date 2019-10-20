using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dignify
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            MainPage.SetValue(NavigationPage.BarBackgroundColorProperty, "#A7D86D");

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
