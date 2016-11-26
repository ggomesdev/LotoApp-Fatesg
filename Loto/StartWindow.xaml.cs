using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Loto
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnLotoFacil_Click(object sender, RoutedEventArgs e)
        {         
            
        }

        private async void btnMegaSena_Click(object sender, RoutedEventArgs e)
        {
            JsonWebClient client = new JsonWebClient();
            var resp = await client.DoRequestJsonAsync<Newtonsoft.Json.Linq.JObject>("http://confiraloterias.com.br/api0/json.php?loteria=lotofacil&token=6nDwFOgoJRxrNQO");
            string result = "about property value is: " + resp["concurso"];
            string result2 = resp["concurso"]["numero"].ToString();

            string teste = "delta";
               
            //resultText.Text = result;

        }
    }
}
