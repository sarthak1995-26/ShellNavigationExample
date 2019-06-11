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
            //Shell.Current.Navigation.RemovePage(
            //    Shell.Current.Navigation.NavigationStack[
            //        Shell.Current.Navigation.NavigationStack.Count - 2]);
            try
            {
                await Shell.Current.Navigation.PopAsync();
                await Shell.Current.Navigation.PopAsync();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"{ex.Message}\n{ex.StackTrace}");
            }
        }
    }
}