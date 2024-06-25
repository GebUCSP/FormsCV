using forms.Services;
using forms.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace forms
{
    public partial class App : Application
    {

        public App(Page initial)
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = initial;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
