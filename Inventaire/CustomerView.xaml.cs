using BillingManagement.Models;
using BillingManagement.UI.ViewModels;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;

namespace BillingManagement.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow(CustomersViewModels vm)
        {
            InitializeComponent();

            DataContext = vm;
        }
        private void CommonCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;

           
            new CustomersViewModels = 
        }
    }
}
