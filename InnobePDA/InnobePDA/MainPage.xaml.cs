using InnobePDA.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InnobePDA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void InboundButton_Clicked(object sender, EventArgs e)
        {
            foreach (var item in Navigation.NavigationStack)
            {
                //중복 클릭 방지
                if (item.ToString().EndsWith("InboundPage"))
                {
                    return;
                }
            }

            await Navigation.PushAsync(new InboundPage());

        }
    }
}
