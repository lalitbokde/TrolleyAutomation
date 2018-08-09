using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrolleyAutomation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TrolleyMainPage : ContentPage
	{
		public TrolleyMainPage ()
		{
			InitializeComponent ();
            leftForward.Text = "-->>Forward-->>";
            leftReverse.Text = "<<--Reverse<<--";
            rightForward.Text = "-->>Forward-->>";
            rightReverse.Text = "<<--Reverse<<--";


            SLTrolley1.IsVisible = false;
            SLTrolley3.IsVisible = false;
            SLTrolley5.IsVisible = true;
            SLTrolley7.IsVisible = false;

            SLTrolley9.IsVisible = false;
            SLTrolley11.IsVisible = false;
            SLTrolley13.IsVisible = false;
            SLTrolley15.IsVisible = false;
            SLTrolley17.IsVisible = false;
            SLTrolley19.IsVisible = false;
         
            SLTrolley21.IsVisible = false;
            SLTrolley23.IsVisible = false;
            SLTrolley25.IsVisible = true;
            SLTrolley27.IsVisible = false;
            SLTrolley29.IsVisible = false;
            SLTrolley31.IsVisible = false;
            SLTrolley33.IsVisible = false;
            SLTrolley35.IsVisible = false;



        }
    }
}