using System;
using System.Collections.Generic;
using System.ComponentModel;
using tp2.Models;
using tp2.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tp2.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}