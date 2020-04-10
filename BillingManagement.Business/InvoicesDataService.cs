using BillingManagement.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace BillingManagement.Business
{
    public class InvoicesDataService : IDataService<Invoice>
    {
        List<Invoice> invoices;
        List<Customer> customers;
        public InvoicesDataService(ObservableCollection<Customer> customerDB)
        {
            customers = customerDB.ToList();
            Random rnd = new Random();

            foreach (Customer c in customers)
            {

                    c.InvoiceCustomer = new ObservableCollection<Invoice>();

                    var invoices = new Invoice();

                    invoices.Customer = c;
                    invoices.InvoiceId = rnd.Next(1000, 2000);
                    invoices.SubTotal = rnd.Next(500,1000);
                    c.InvoiceCustomer.Add(invoices);
            }
        }
        public IEnumerable<Invoice> GetAll()
        {
            foreach (Invoice c in invoices)
            {
                yield return c;
            }
        }

    }
}
