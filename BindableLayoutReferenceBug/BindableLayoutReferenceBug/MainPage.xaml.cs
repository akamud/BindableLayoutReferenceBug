using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BindableLayoutReferenceBug
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_ListViewClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ListViewPage());
        }

        void Handle_StackLayoutClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new BindableLayoutPage());
        }
    }
}
