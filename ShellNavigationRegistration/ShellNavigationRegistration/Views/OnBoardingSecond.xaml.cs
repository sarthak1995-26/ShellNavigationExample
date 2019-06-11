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
    public partial class OnBoardingSecond : ContentPage
    {
        public OnBoardingSecond()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new OnBoardingThird(), true);
        }
    }
}