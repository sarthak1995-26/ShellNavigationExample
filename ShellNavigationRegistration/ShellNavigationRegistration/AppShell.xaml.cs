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
            GoToAsync("Items");
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
