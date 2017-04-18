﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace KocaeliUlasim
{
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();

            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(700, 500));
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += SystemNavigationManager_BackRequested;

            var appView = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView();

            iframe.Navigate(typeof(View.StartScreen));
        }


        #region BackRequested Handlers

        private void SystemNavigationManager_BackRequested(object sender, BackRequestedEventArgs e)
        {
            bool handled = e.Handled;
            this.BackRequested(ref handled);
            e.Handled = handled;
        }
            
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            bool ignored = false;
            this.BackRequested(ref ignored);
        }

        private void BackRequested(ref bool handled)
        {
            if (this.iframe == null)
                return;

            if (this.iframe.CanGoBack && !handled)
            {
                handled = true;
                this.iframe.GoBack();
            }
        }


        #endregion

    }
}
