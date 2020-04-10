using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace BillingManagement.Models
{
    public class Invoice : INotifyPropertyChanged
    {
        private int invoiceId;
        private Customer customer;
        private double subtotal;
        private double fedtax = 0.05;
        private double provtax = 0.09975;
        private double total;

        public Invoice()
        {
            CreationDateTime = new DateTime();
        }

        public Invoice(Customer customer)
        {
            Customer = customer;
            
            OnPropertyChanged(nameof(CreationDateTime));
        }

        public int InvoiceId
        {
            get => invoiceId;
            set
            {
                invoiceId = value + 1;
                OnPropertyChanged();
            }
        }

        public DateTime CreationDateTime { get; private set; }

        public Customer Customer
        {
            get => customer;

            set
            {
                customer = value;
                OnPropertyChanged();

            }
        }


        public double SubTotal
        {
            get => subtotal;

            set
            {
                subtotal = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FedTax));
                OnPropertyChanged(nameof(ProvTax));
                OnPropertyChanged(nameof(Total));
            }
        }

        public double FedTax
        {
            get => SubTotal * fedtax;
        }

        public double ProvTax
        {
            get => SubTotal * provtax; 
        }

        public double Total
        {
            get => SubTotal + ProvTax + FedTax;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

