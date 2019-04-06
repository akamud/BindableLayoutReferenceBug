using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BindableLayoutReferenceBug
{
    public partial class BindableLayoutPage : ContentPage
    {
        public BindableLayoutPage()
        {
            InitializeComponent();

            BindingContext = new BindableLayoutPageViewModel();
        }
    }
}
