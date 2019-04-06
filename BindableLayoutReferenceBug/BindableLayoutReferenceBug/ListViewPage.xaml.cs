using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BindableLayoutReferenceBug
{
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            BindingContext = new ListViewPageViewModel();
        }
    }
}
