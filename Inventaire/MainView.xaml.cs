using BillingManagement.UI.ViewModels;
using BillingManagement.Models;
using System.Windows;
using System.Windows.Input;
using BillingManagement.UI.View;

namespace BillingManagement.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

       public CustomersViewModels viewModel;
        public MainWindow(CustomersViewModels vm)
        {
            InitializeComponent();
            DataContext = new CustomersViewModels();
            viewModel = vm;
        }

        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Customer temp = new Customer() { Name = "new", LastName = "customer", Address = "", City = "", Province = "", PostalCode = "", PicturePath = "images/user.png", ContactInfo = "" };
            viewModel.Customers.Add(temp);
            lvCustomers.ItemsSource = viewModel.Customers;
            lvCustomers.SelectedItem = temp;
        }

        private void NewCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CloseCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CloseCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void InvoicesViewChange(object sender, RoutedEventArgs e)
        {
            DataContext = new InvoicesViewModels();
        }

        private void CustomersViewChange(object sender, RoutedEventArgs e)
        {
            DataContext = new CustomersViewModels();
        }
    }
}
