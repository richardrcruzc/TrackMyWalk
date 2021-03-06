﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TrackMyWalks
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

//            MainPage = new TrackMyWalks.MainPage();
            // Check the Target OS Platform
            if (Device.RuntimePlatform==  Device.Android)
            {
                MainPage = new SplashPage();
            }
            else
            {
                // The root page of your application
                var navPage = new NavigationPage(new WalksPage()
                {
                    Title = "Track My Walks"
                });
                MainPage = navPage;
            }

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
