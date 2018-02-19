using System;
using Xamarin.Forms;

namespace App2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        async void onclicked (object sender, EventArgs e)
        {
            var disp = new displaypage();
            await Navigation.PushModalAsync(disp);
        }

    }
}
