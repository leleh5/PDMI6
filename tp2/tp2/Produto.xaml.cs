using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Xamarin.Forms.Internals.GIFBitmap;

namespace tp2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Produto : ContentPage
    {
        public Produto()
        {
            InitializeComponent();
        }

        async void NovaPagina(object sender, EventArgs e)
        {
            var produto = new Product
            {
                Id = int.Parse(ID.Text),
                Descricao = Descricao.Text,
                Categoria = Categoria.Text,
                Quantidade = int.Parse(Quantidade.Text),
                Preco = decimal.Parse(Preco.Text),
            };


            var detalhePage = new DetalheView2();
            detalhePage.BindingContext = produto;
            await Navigation.PushAsync(detalhePage);

        }
    }
}