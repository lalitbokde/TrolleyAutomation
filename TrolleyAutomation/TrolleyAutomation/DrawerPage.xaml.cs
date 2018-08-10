using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrolleyAutomation.Model;
using TrolleyAutomation.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrolleyAutomation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrawerPage : ContentPage
    {
      
        //public List<DrawerMenuItem> menuList{ get;set;}
        public DrawerPage()
        {
            InitializeComponent();
            //    menuList = new List<DrawerMenuItem>();
            //    // Adding menu items to menuList and you can define title ,page and icon  
            //    menuList.Add(new DrawerMenuItem()
            //    {
            //        Title = "Trolley 1 Setting",
            //        IconSource = "icons8_cart.png",
            //        TargetType = typeof(Trolley1SettingPage)
            //    });
            //    menuList.Add(new DrawerMenuItem()
            //    {
            //        Title = "Trolley 2 Setting",
            //        IconSource = "icons8_cart.png",
            //        TargetType = typeof(Trolley2SettingPage)
            //    });
            //    menuList.Add(new DrawerMenuItem()
            //    {
            //        Title = "Trolley Setup",
            //        IconSource = "icons8_setup.png",
            //        TargetType = typeof(TrolleySetupPage)
            //    });
            //    menuList.Add(new DrawerMenuItem()
            //    {
            //        Title = "Alarm Setting",
            //        IconSource = "icons8_alarm.png",
            //        TargetType = typeof(AlarmSettingPage)
            //    });
            //    menuList.Add(new DrawerMenuItem()
            //    {
            //        Title = "GIN Details",
            //        IconSource = "icons8_viewDetail.png",
            //        TargetType = typeof(GINDetailsPage)
            //    });
            //    menuList.Add(new DrawerMenuItem()
            //    {
            //        Title = "Setting",
            //        IconSource = "icons8_settings.png",
            //        TargetType = typeof(SettingPage)
            //    });
            //    menuList.Add(new DrawerMenuItem()
            //    {
            //        Title = "Help",
            //        IconSource = "icons8_help.png",
            //        TargetType = typeof(HelpPage)
            //    });
            //    menuList.Add(new DrawerMenuItem()
            //    {
            //        Title = "Log Out",
            //        IconSource = "icons8_logout.png",
            //        TargetType = typeof(LogOutPage)
            //    });
            //    // Setting our list to be ItemSource for ListView in MainPage.xaml  
            //    DrawerMenuList.ItemsSource = menuList;
            //    // Initial navigation, this can be used for our home page  
            //    Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(TrolleyMainPage)));
            }
            private void DrawerMenuList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
            {
                //var item = (DrawerMenuItem)e.SelectedItem;
                //Type page = item.TargetType;
                //Detail = new NavigationPage((Page)Activator.CreateInstance(page));
                //IsPresented = false;

            }

    }
}
