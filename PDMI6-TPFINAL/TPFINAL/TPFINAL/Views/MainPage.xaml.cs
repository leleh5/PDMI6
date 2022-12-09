using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TPFINAL.Models;
using TPFINAL.ViewModels;
using TPFINAL.Views;

namespace TPFINAL
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage {
        MercadoriaViewModel vmMercadoria;
        public MainPage() {
            vmMercadoria = new MercadoriaViewModel();
            BindingContext = vmMercadoria;
            InitializeComponent();
        }
        protected override void OnAppearing() {
            vmMercadoria = new MercadoriaViewModel();
            BindingContext = vmMercadoria;
            base.OnAppearing();
        }
        private void OnNovo(object sender, EventArgs args) {
            Navigation.PushAsync(new NovaMercadoria());
        }

        private void OnAutores(object sender, EventArgs args) {
            DisplayAlert("Autores", "Bruna de Paula da Silva\nLeticia Vitoria Rodrigues Rosa", "OK");
        }

        async private void OnMercadoriaTapped(object sender, ItemTappedEventArgs args) {
            var selecionado = args.Item as Mercadoria;
            string action = await DisplayActionSheet(selecionado.Nome, "Cancelar", "Deletar", "Editar");

            switch (action) {
                case "Deletar":
                    vmMercadoria.DeletarMercadoria(selecionado);
                    await Navigation.PushAsync(new MainPage());
                    break;
                case "Editar":
                    await Navigation.PushAsync(new NovaMercadoria(selecionado));
                    break;
               
            }
        }

        async private void OnCoord(object sender, EventArgs e) {
            try {
                var localizacao = await Geolocation.GetLastKnownLocationAsync();

                if (localizacao != null) {                                 
                    await DisplayAlert("Localização", "Latitude: " + localizacao.Latitude.ToString() + "\nLongitude: " + localizacao.Longitude.ToString(), "OK");
                }
            }
            catch (FeatureNotSupportedException fnsEx) {
                await DisplayAlert("Erro ", fnsEx.Message, "Ok");
            }
            catch (PermissionException pEx) {
                await DisplayAlert("Erro: ", pEx.Message, "Ok");
            }
            catch (Exception ex) {
                await DisplayAlert("Erro : ", ex.Message, "Ok");
            }
        }
    }
}
