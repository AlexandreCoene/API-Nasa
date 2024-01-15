using Api_Nasa.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Web;


namespace Api_Nasa.View
{
    /// <summary>
    /// Logique d'interaction pour PageDaily.xaml
    /// </summary>
    public partial class PageDaily : UserControl // UserControl pour afficher la page de l'anniversaire de l'utilisateur
    {
        APOD apod; // Créez un nouvel objet APOD
        public PageDaily() // Constructeur
        {
            InitializeComponent();

            apod = new APOD(); // Créez un nouvel objet APOD
            GetApod(); // Appel de la méthode GetApod
        }
        public async Task<string> GetApod() // Méthode pour appeler l'API
        {
            try
            {
                HttpClient client2 = new HttpClient(); // Créez un nouveau client HTTP
                HttpResponseMessage response = await client2.GetAsync("https://api.nasa.gov/planetary/apod?api_key=v9HunsPsDTtKfQxMg0wuhr7zcx5JaT9JqYCLwEjp"); // Appel de l'API avec la ville

                if (response.IsSuccessStatusCode) // Vérifiez si la réponse est un succès
                {
                    var content = await response.Content.ReadAsStringAsync(); // Lire le contenu de la réponse
                    APOD.Root myDeserializedClass = JsonConvert.DeserializeObject<APOD.Root>(content); // Désérialiser le contenu de la réponse
                    IMG_APOD.Source = new BitmapImage(new Uri(myDeserializedClass.url)); // Afficher l'image
                    LBL_Titre.Content = "Titre : " + myDeserializedClass.title; // Afficher le titre
                    LBL_Description.Text = "Description : " + myDeserializedClass.explanation; // Afficher la description   

                    if (content.Contains("error")) // Vérifiez si le contenu contient le mot erreur
                    {
                        MessageBox.Show("Donnée non trouvée"); // Afficher une erreur
                        return "ok"; // Retourne
                    }

                }
                return "OK"; // Retourne OK
            }

            catch (Exception ex) // Attraper une exception
            {
                Console.WriteLine("Exception during GetWeather: " + ex.Message); // Afficher une exception
                return "KO"; // Retourne KO
            }
        }

        private void BTN_APOD_Click(object sender, RoutedEventArgs e) // Bouton pour ouvrir l'url de la photo de l'anniversaire de l'utilisateur
        {
            try
            {                
                string url = "https://science.nasa.gov/mission/hubble/multimedia/what-did-hubble-see-on-your-birthday/"; // Définir l'url
                Process.Start(url); // Ouvrir l'url
            }
            catch (Exception ex) // Attraper une exception
            {
                Console.WriteLine("Exception in BTN_APOD_Click: " + ex.Message); // Afficher une exception
            }
        }
    }
}
