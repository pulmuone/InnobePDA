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
        public Entry _entry;

        public InboundViewModel()
        {
            SearchInvoiceCommand = new Command(SearchInvoice);
            SearchInvoice2Command = new Command<object>((obj) => SearchInvoice2(obj));

        }
        private void SearchInvoice()
        {
            Debug.WriteLine(InvoiceNo);
        }

        private void SearchInvoice2(object obj)
        {
            Debug.WriteLine(InvoiceNo2);
            ((Entry)obj).Focus();
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
