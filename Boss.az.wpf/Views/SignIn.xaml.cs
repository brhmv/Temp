using Boss.az.wpf.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Boss.az.wpf.Views
{
    public partial class SignIn : UserControl
    {
        public SignIn()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
