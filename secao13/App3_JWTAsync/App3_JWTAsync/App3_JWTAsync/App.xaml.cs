﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3_JWTAsync
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new App3_JWTAsync.MainPage();
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
