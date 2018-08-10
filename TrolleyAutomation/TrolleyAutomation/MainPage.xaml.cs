using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrolleyAutomation.Model;
using TrolleyAutomation.Views;
using Xamarin.Forms;

namespace TrolleyAutomation
{
	public partial class MainPage : MasterDetailPage
	{
        public List<DrawerMenuItem> menuList { get; set; }
        public MainPage()
		{
			InitializeComponent();
            menuList = new List<DrawerMenuItem>();
            // Adding menu items to menuList and you can define title ,page and icon  
            menuList.Add(new DrawerMenuItem()
            {
                Title = "Trolley 1 Setting",
                IconSource = "icons8_cart.png",
                TargetType = typeof(Trolley1SettingPage)
            });
            menuList.Add(new DrawerMenuItem()
            {
                Title = "Trolley 2 Setting",
                IconSource = "icons8_cart.png",
                TargetType = typeof(Trolley2SettingPage)
            });
            menuList.Add(new DrawerMenuItem()
            {
                Title = "Trolley Setup",
                IconSource = "icons8_setup.png",
                TargetType = typeof(TrolleySetupPage)
            });
            menuList.Add(new DrawerMenuItem()
            {
                Title = "Alarm Setting",
                IconSource = "icons8_alarm.png",
                TargetType = typeof(AlarmSettingPage)
            });
            menuList.Add(new DrawerMenuItem()
            {
                Title = "GIN Details",
                IconSource = "icons8_viewDetail.png",
                TargetType = typeof(GINDetailsPage)
            });
            menuList.Add(new DrawerMenuItem()
            {
                Title = "Setting",
                IconSource = "icons8_settings.png",
                TargetType = typeof(SettingPage)
            });
            menuList.Add(new DrawerMenuItem()
            {
                Title = "Help",
                IconSource = "icons8_help.png",
                TargetType = typeof(HelpPage)
            });
            menuList.Add(new DrawerMenuItem()
            {
                Title = "Log Out",
                IconSource = "icons8_logout.png",
                TargetType = typeof(LogOutPage)
            });
            // Setting our list to be ItemSource for ListView in MainPage.xaml  
            DrawerMenuList.ItemsSource = menuList;
            // Initial navigation, this can be used for our home page  
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(TrolleyMainPage)));
        }
        private void DrawerMenuList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (DrawerMenuItem)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;

        }

    }

}
        //protected async override void OnAppearing()
        //{
          
          
        //}
        //int i = 1;
        //private bool CheckPositionAndUpdateSlider()
        //{

       
        //        SLTrolley1.IsVisible = false;
        //    SLTrolley3.IsVisible = false;
        //    SLTrolley5.IsVisible = false;
        //    SLTrolley7.IsVisible = false;

        //    SLTrolley9.IsVisible = false;
        //    SLTrolley11.IsVisible = false;
        //    SLTrolley13.IsVisible = false;
        //    SLTrolley15.IsVisible = false;
        //    SLTrolley17.IsVisible = false;
        //    SLTrolley19.IsVisible = false;
        //    Trolley1(i);
          
        //    i++;
        //    if (i == 8)
        //    { i = 1; }
        //      return true;
        //}

        //private void Trolley1(int i)
        //{
        //    switch (i)
        //    {
        //        case 1:
        //            SLTrolley1.IsVisible = true;
        //            break;
        //        case 2:
        //            SLTrolley3.IsVisible = true;
        //            break;
        //        case 3:
        //            SLTrolley5.IsVisible = true;
        //            break;

        //        case 4:
        //            SLTrolley7.IsVisible = true;
        //            break;

        //        case 5:
        //            SLTrolley9.IsVisible = true;
        //            break;

        //        case 6:
        //            SLTrolley11.IsVisible = true;
        //            break;

        //        case 7:
        //            SLTrolley13.IsVisible = true;
        //            break;

        //        case 8:
        //            SLTrolley15.IsVisible = true;
        //            break;

        //        default:
        //            break;
        //    }

        //}

        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //      Device.StartTimer(TimeSpan.FromSeconds(5000), CheckPositionAndUpdateSlider);
       //}
//    }
//}
