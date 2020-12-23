using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace InnobePDA.ViewModels
{
    public class InboundViewModel : ViewModelBase
    {
        public ICommand SearchInvoiceCommand { get; }
        public ICommand SearchInvoice2Command { get; }
        private string _invoiceNo;
        private string _invoiceNo2;

        public InboundViewModel()
        {
            SearchInvoiceCommand = new Command(SearchInvoice);
            SearchInvoice2Command = new Command(SearchInvoice2);
        }
        private void SearchInvoice()
        {
            Debug.WriteLine(InvoiceNo);
        }

        private void SearchInvoice2()
        {
            Debug.WriteLine(InvoiceNo2);
        }

        public string InvoiceNo
        {
            get => _invoiceNo;
            set => SetProperty(ref this._invoiceNo, value);
        }

        public string InvoiceNo2
        {
            get => _invoiceNo2;
            set => SetProperty(ref this._invoiceNo2, value);
        }
    }
}
