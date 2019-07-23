﻿using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using HotUI.Samples;

namespace HotUI.Android.Sample
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : HotUIActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
#if DEBUG
            HotUI.Reload.Init();
#endif
            HotUI.Skia.Android.UI.Init();

            Page = new MainPage();
        }
    }
}

