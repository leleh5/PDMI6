using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tp2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dinamico : ContentPage
    {
        public Dinamico()
        {
            InitializeComponent();

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                Device.BeginInvokeOnMainThread(() =>
                lblTime.Text = DateTime.Now.ToString());

                return true;
            });
        }
    }
}