﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppConselhos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new View.PaginaConselho();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
