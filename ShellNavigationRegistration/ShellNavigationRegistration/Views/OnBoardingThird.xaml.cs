using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellNavigationRegistration.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OnBoardingThird : ContentPage
    {
        public OnBoardingThird()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Shell.Current.Navigation.RemovePage(
                Shell.Current.Navigation.NavigationStack[
                    Shell.Current.Navigation.NavigationStack.Count - 2]);

            await Shell.Current.Navigation.PopAsync();
        }
    }
}