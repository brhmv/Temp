using Boss.az.wpf.View;
using Boss.az.wpf.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Boss.az.wpf.ViewModels
{
    internal class MainViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string? propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public UserControl? _SignInUpHolderControlPro;
        public UserControl? SignInUpHolderControlPro
        {
            get { return _UC; }
            set { _UC = value; OnPropertyChanged(nameof(SignInUpHolderControlPro)); }
        }

        UserControl? _UC;
        public UserControl? CurrentViewModel
        {
            get { return _UC; }
            set { _UC = value; OnPropertyChanged(nameof(CurrentViewModel)); }
        }


        public string? User { get; set; }


        public string? Name { get; set; }
        public string? Password { get; set; }


        public MainViewModel()
        {
        }

        public RelayCommand UserIsWorker
        {
            get => new RelayCommand(() =>
        {
            User = "Worker";

            App.window.Content = new SignInUp();
        });
        }

        public RelayCommand UserIsEmployer
        {
            get => new RelayCommand(() =>
            {
                User = "Employer";
            });
        }

        public RelayCommand SignUpButton
        {
            get => new RelayCommand(() =>
            {
                SignInUpHolderControlPro = new SignUp();

            });
        }

        public RelayCommand SignInButton
        {
            get => new RelayCommand(() =>
            {
                SignInUpHolderControlPro = new SignIn();


            });
        }


        public RelayCommand SignIn_Button_Click
        {
            get => new RelayCommand(() =>
            {
                SignIn si = new();
                //si.SignIn_Button.IsEnabled= true;

            });
        }


    }
}