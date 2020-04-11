using BillingManagement.Business;
using BillingManagement.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BillingManagement.UI.ViewModels
{
    public class InvoicesViewModels : BaseViewModels
    {
        CustomersDataService customersDataService = new CustomersDataService();

        private ObservableCollection<Customer> invoicesustomers;
        private Customer selectedCustomer;

        public ObservableCollection<Customer> InvoicesCustomers
        {
            get => invoicesustomers;
            private set
            {
                invoicesustomers = value;
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
        public InvoicesViewModels()
        {
            InitValues();
        }

        private void InitValues()
        {
            InvoicesCustomers = new ObservableCollection<Customer>(customersDataService.GetAll());
            

        }

    }
}
