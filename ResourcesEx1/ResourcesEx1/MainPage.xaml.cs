using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ResourcesEx1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
			Application.Current.Resources["DefaultTitle"] =
				Application.Current.Resources["NewTitle"];
			Application.Current.Resources["DefaultButton"] =
				Application.Current.Resources["NewButton"];
			Application.Current.Resources["DefaultStackLayout"] =
				Application.Current.Resources["NewStackLayout"];
			Application.Current.Resources["DefaultEditor"] =
				Application.Current.Resources["NewEditor"];
		}
    }
}
