using BillingManagement.UI.ViewModels;
using BillingManagement.Models;
using System.Windows;
using System.Windows.Input;

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
        private void Nouveau_clients(object sender, RoutedEventArgs e)
        {
            Customer temp = new Customer() { Name = "new", LastName = "customer", Address = "", City = "", Province = "", PostalCode = "", PicturePath = "images/user.png", ContactInfo = "" };
            viewModel.Customers.Add(temp);
            lvCustomers.ItemsSource = viewModel.Customers;
            lvCustomers.SelectedItem = temp;
        }


     
    }
}
