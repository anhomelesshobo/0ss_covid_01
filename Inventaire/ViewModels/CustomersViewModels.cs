using BillingManagement.Business;
using BillingManagement.Models;
using System.Collections.ObjectModel;
using BillingManagement.UI;
using System.Diagnostics;

namespace BillingManagement.UI.ViewModels
{
   public class CustomersViewModels : BaseViewModels
    {
        CustomersDataService customersDataService = new CustomersDataService();

        private ObservableCollection<Customer> customers;
        private Customer selectedCustomer;

        public ObservableCollection<Customer> Customers
        {
            get => customers;
            private set
            {
                customers = value;
                OnPropertyChanged();
            }
        }

        public Customer SelectedCustomer
        {
            get => selectedCustomer;
            set
            {
                selectedCustomer = value;
                OnPropertyChanged();
            }
        }

        public CustomersViewModels()
        {
            InitValues();
        }

        private void InitValues()
        {
            Customers = new ObservableCollection<Customer>(customersDataService.GetAll());
            
        }
    }
}
