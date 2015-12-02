using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TableViewinWP
{
    public class App : Application
    {
        public App()
        {   
            // This fails 
            //MainPage = new NavigationPage(new FirstPage());

            // This works 
            MainPage = new NavigationPage(new SecondPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
