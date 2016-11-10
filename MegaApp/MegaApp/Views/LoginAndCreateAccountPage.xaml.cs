﻿using Windows.UI.Xaml;
using MegaApp.Services;
using MegaApp.UserControls;
using MegaApp.ViewModels;

namespace MegaApp.Views
{
    // Helper class to define the viewmodel of this page
    // XAML cannot use generic in it's declaration.
    public class BaseLoginAndCreateAccountPage : PageEx<LoginAndCreateAccountViewModel> {}
   
    public sealed partial class LoginAndCreateAccountPage : BaseLoginAndCreateAccountPage
    {
        public LoginAndCreateAccountPage()
        {
            InitializeComponent();            
        }

        private void OnAcceptClick(object sender, RoutedEventArgs e)
        {
            if (!NetworkService.IsNetworkAvailable(true)) return;
                        
            if (Pivot_LoginAndCreateAccount?.SelectedItem == PivotItem_Login)
                this.ViewModel?.LoginViewModel?.DoLogin();
            else if (Pivot_LoginAndCreateAccount?.SelectedItem == PivotItem_CreateAccount)
                this.ViewModel?.CreateAccountViewModel?.CreateAccount();
        }
    }
}
