using Boss.az.wpf.View;
using Boss.az.wpf.ViewModels;
using Boss.az.wpf.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Boss.az.wpf
{
    public partial class App : Application
    {
        public static MainView? window { get; set; }



        protected override void OnStartup(StartupEventArgs e)
        {
            window = new MainView
            {
                DataContext = new MainViewModel()                
            };
            window.Content_Control.Content = new WorkerOrEmployer();



            SignInUp siu = new();
            siu.SignInUpHolderControl.Content = new SignIn();


            window.Show();
            base.OnStartup(e);
        }
    }
}
