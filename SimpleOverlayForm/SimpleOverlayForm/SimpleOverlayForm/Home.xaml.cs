
using System;
using Xamarin.Forms;

namespace SimpleOverlayForm
{
    public partial class Home : ContentPage
    {
        
        public Home()
        {
            InitializeComponent();
        }
        
        void OnButtonClicked(object sender, EventArgs args)
        {
            EnteredName.Text = string.Empty;

            overlay.IsVisible = true;

            EnteredName.Focus();
        }

        void OnOKButtonClicked(object sender, EventArgs args)
        {
            overlay.IsVisible = false;

            DisplayAlert("Result", string.Format("You entered {0}", EnteredName.Text), "OK");
        }

        void OnCancelButtonClicked(object sender, EventArgs args)
        {
            overlay.IsVisible = false;
        }
    }
}
