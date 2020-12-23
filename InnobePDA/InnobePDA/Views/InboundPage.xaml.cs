using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InnobePDA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InboundPage : ContentPage
    {
        public InboundPage()
        {
            InitializeComponent();
        }

        private void InvoiceNo_Completed(object sender, EventArgs e)
        {
            Debug.WriteLine(this.InvoiceNo.Text);
        }

        private void InvoiceNo2_Completed(object sender, EventArgs e)
        {
            Debug.WriteLine(this.InvoiceNo2.Text);
        }

    }
}