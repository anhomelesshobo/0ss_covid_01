using BillingManagement.UI.View;
using BillingManagement.UI.ViewModels;
using System.Windows;

namespace BillingManagement.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        MainWindow _wnd;

        public App()
        {
            CustomersViewModels vm = new CustomersViewModels();
            _wnd = new MainWindow(vm);


            _wnd.Show();
        }
    }
}
