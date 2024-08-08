using System;
using Theraputic.Services;
using Theraputic.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Theraputic
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
