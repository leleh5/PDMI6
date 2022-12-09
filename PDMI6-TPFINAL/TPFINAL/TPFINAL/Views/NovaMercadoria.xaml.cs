using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TPFINAL.Models;

namespace TPFINAL.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NovaMercadoria : ContentPage
    {
        public NovaMercadoria()
        {
            InitializeComponent();
        }

        public NovaMercadoria(Mercadoria mercadoria)
        {
            InitializeComponent();
            txtNome.Text = mercadoria.Nome;
            txtPeso.Text = mercadoria.Peso;
            txtProdutor.Text = mercadoria.NomeProdutor;
            txtEmail.Text = mercadoria.EmailProdutor;
            txtNCM.Text = mercadoria.NCM.ToString();
           
        }
        public void OnSalvar(object sender, EventArgs args)
        {
            Mercadoria mercadoria = new Mercadoria()
            {
                Nome = txtNome.Text,
                Peso = txtPeso.Text,
                NomeProdutor = txtProdutor.Text,
                EmailProdutor = txtEmail.Text,
                NCM = int.Parse(txtNCM.Text)
            };
          
            App.MercadoriaModel.SalvarMercadoria(mercadoria);
            Limpar();
            Navigation.PopAsync();
        }
        public void OnCancelar(object sender, EventArgs args)
        {
            Limpar();
            Navigation.PopAsync();
        }
        private void Limpar()
        {
            txtNome.Text = txtProdutor.Text = txtEmail.Text = txtNCM.Text = string.Empty;
        }
    }   
}