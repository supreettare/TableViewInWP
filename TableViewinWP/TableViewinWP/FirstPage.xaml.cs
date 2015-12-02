using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TableViewinWP
{
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new SecondPage()); 
        }
    }
}
