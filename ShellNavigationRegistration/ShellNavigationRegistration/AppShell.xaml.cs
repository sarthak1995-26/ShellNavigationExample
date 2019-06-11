using ShellNavigationRegistration.Views;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ShellNavigationRegistration
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            RegisterRoutes();

            //GoToAsync("on-boarding");
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute("on-boarding", typeof(OnBoarding));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
