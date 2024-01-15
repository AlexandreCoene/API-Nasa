using System;
using System.Collections.Generic;
using System.Linq;
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
using Api_Nasa.Service;
using Newtonsoft.Json;
using System.Net.Http;

namespace Api_Nasa.View
{
    /// <summary>
    /// Logique d'interaction pour View_Mars.xaml
    /// </summary>
    public partial class View_Mars : UserControl // UserControl
    {
        Mars_Rover mars; // Instanciez la classe Mars_Rover

        public View_Mars() // Constructeur
        {
            InitializeComponent(); // Initialisez les composants

            mars = new Mars_Rover(); // Instanciez la classe Mars_Rover
            GetMars(); // Appelez la méthode GetMars
        }

        public async Task<string> GetMars() // Méthode GetMars
        {
            try
            {
                DateTime dateSelectionnee = DP_Date.SelectedDate ?? DateTime.Now; // Obtenez la date sélectionnée depuis le DatePicker ou utilisez la date actuelle
                string dateFormatee = dateSelectionnee.ToString("yyyy-MM-dd"); // Formatez la date sélectionnée au format "yyyy-MM-dd"

                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync($"https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?earth_date={dateFormatee}&camera=NAVCAM&api_key=v9HunsPsDTtKfQxMg0wuhr7zcx5JaT9JqYCLwEjp"); // Obtenez la réponse de l'API

                if (response.IsSuccessStatusCode) // Si la réponse est un succès
                {
                    var contenu = await response.Content.ReadAsStringAsync(); // Obtenez le contenu de la réponse
                    Mars_Rover.Root maClasseDeserialisee = JsonConvert.DeserializeObject<Mars_Rover.Root>(contenu); // Désérialisez le contenu de la réponse dans la classe Root

                    LBL_Titre.Content = "Titre : " + maClasseDeserialisee.photos[0].camera.full_name + " | Date : " + maClasseDeserialisee.photos[0].earth_date; // Titre
                    IMG_Photo.Source = new BitmapImage(new Uri(maClasseDeserialisee.photos[0].img_src)); // Image

                    LBL_Titre2.Content = "Titre : " + maClasseDeserialisee.photos[58].camera.full_name + " | Date : " + maClasseDeserialisee.photos[58].earth_date; // Titre
                    IMG_Photo2.Source = new BitmapImage(new Uri(maClasseDeserialisee.photos[58].img_src)); // Image

                    LBL_Titre1.Content = "Titre : " + maClasseDeserialisee.photos[2].camera.full_name + " | Date : " + maClasseDeserialisee.photos[2].earth_date; // Titre
                    IMG_Photo1.Source = new BitmapImage(new Uri(maClasseDeserialisee.photos[2].img_src)); // Image

                    LBL_Nom.Content = "Rover : " + maClasseDeserialisee.photos[2].rover.name; // Nom du rover
                    LBL_Landing_Date.Content = "Date d'atterrissage : " + maClasseDeserialisee.photos[2].rover.landing_date; // Date d'atterrissage
                    LBL_Launch_Date.Content = "Date de lancement : " + maClasseDeserialisee.photos[2].rover.launch_date; // Date de lancement
                    LBL_Status.Content = "Status : " + maClasseDeserialisee.photos[2].rover.status; // Status
                    LBL_Max_Sol.Content = "Sol Max : " + maClasseDeserialisee.photos[2].rover.max_sol; // Sol Max
                    LBL_Max_Date.Content = "Date Max : " + maClasseDeserialisee.photos[2].rover.max_date; // Date Max
                    LBL_Total_Photo.Content = "Totale De Photo Prise : " + maClasseDeserialisee.photos[2].rover.total_photos; // Totale De Photo Prise

                    if (contenu.Contains("error")) // Si la réponse contient "error"
                    {
                        System.Windows.MessageBox.Show("Donnée non trouvée"); // Affichez un message d'erreur
                        return "ok"; // Retourne "ok"
                    }
                }
                return "OK";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception lors de GetMars : " + ex.Message); // Affichez un message d'erreur
                return "KO"; // Retourne "KO"
            }
        }

        private async void DP_Date_SelectedDateChanged(object sender, SelectionChangedEventArgs e) // Lorsque la date est changée
        {
            await GetMars(); // Appelez la méthode GetMars
        }
    }
}


