using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using authgear;

namespace authgearapp
{
    public partial class App : Application

    {

        private Authgear authgear;

        public App(Authgear authgear)
        {
            InitializeComponent();

            MainPage = new MainPage();

            this.authgear = authgear;
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
        public void SayHello()
        {
            this.authgear.SayHello();
        }
    }
}
