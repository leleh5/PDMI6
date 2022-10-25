using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;
using System.Net.Security;

namespace TP02APP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Login();
        }

        public async void Login()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("http://10.0.0.101:5116/api/Logins1");
            Console.WriteLine(response);
            var login = JsonConvert.DeserializeObject<List<Login>>(response);
            ListLogin.ItemsSource = login;
        }

        public async void Reload(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("http://10.0.0.101:5116/api/Logins1");
            Console.WriteLine(response);
            var login = JsonConvert.DeserializeObject<List<Login>>(response);
            ListLogin.ItemsSource = login;
        }
    }
}
