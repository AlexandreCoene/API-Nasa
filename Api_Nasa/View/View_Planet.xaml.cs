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
using Api_Nasa.Service; 
using Newtonsoft.Json;

namespace Api_Nasa.View
{
    /// <summary>
    /// Logique d'interaction pour View_Planet.xaml
    /// </summary>
    public partial class View_Planet : UserControl // UserControl
    {
        ISS iss; // Instanciez la classe Mars_Rover
        public View_Planet() // Constructeur
        {
            ISS iss = new ISS(); // Instanciez la classe Mars_Rover
            InitializeComponent();
            GetISS(); // Appelez la méthode GetMars
            GetPerso(); // Appelez la méthode GetMars
        }

        public async Task<string> GetISS() // Méthode GetMars
        {
            try
            {
                HttpClient client = new HttpClient(); // Instanciez la classe HttpClient
                HttpResponseMessage response = await client.GetAsync("http://api.open-notify.org/iss-now.json"); // Obtenez la réponse de l'API

                if (response.IsSuccessStatusCode) // Si la réponse est un succès
                {
                    var contenu = await response.Content.ReadAsStringAsync(); // Obtenez le contenu de la réponse
                    ISS.Root maClasseDeserialisee = JsonConvert.DeserializeObject<ISS.Root>(contenu); // Désérialisez le contenu de la réponse dans la classe Root
                    ISS.IssPosition maClasseDeserialisee2 = maClasseDeserialisee.iss_position; // Désérialisez le contenu de la réponse dans la classe Root
                    LBL_Longitude.Content = "Longitude ISS : " + maClasseDeserialisee2.longitude; // Affichez la longitude de l'ISS
                    LBL_Latitude.Content = "Latitude ISS : " + maClasseDeserialisee2.latitude; // Affichez la latitude de l'ISS
                    if (contenu.Contains("error")) // Si le contenu de la réponse contient "error"
                    {
                        System.Windows.MessageBox.Show("Donnée non trouvée"); // Affichez un message d'erreur
                        return "ok"; // Retournez "ok"
                    }
                }

                return "OK";

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception lors de GetMars : " + ex.Message);
                return "KO";
            }
        }

        public async Task<string> GetPerso() // Méthode GetMars
        {
            try
            {
                HttpClient client = new HttpClient(); // Instanciez la classe HttpClient
                HttpResponseMessage response = await client.GetAsync("http://api.open-notify.org/astros.json"); // Obtenez la réponse de l'API

                if (response.IsSuccessStatusCode) // Si la réponse est un succès
                {
                    var contenu = await response.Content.ReadAsStringAsync();
                    Perso.Root maClasseDeserialisee = JsonConvert.DeserializeObject<Perso.Root>(contenu);
                    Perso.Person maClasseDeserialisee2 = maClasseDeserialisee.people[1];
                    LBL_NB_Personne.Content = "Nombre de personne dans l'ISS : " + maClasseDeserialisee.number;  // Affiche le nombre de personne dans l'ISS
                    LBL_Perso1.Content = "Equipier 1 : " + maClasseDeserialisee2.name + " | Craft : " + maClasseDeserialisee2.craft; //Affiche le nom de la premiere personne dans l'ISS
                    LBL_Perso2.Content = "Equipier 2 : " + maClasseDeserialisee.people[2].name + " | Craft : " + maClasseDeserialisee.people[2].craft; // Affiche le nom de la deuxième personne dans l'ISS
                    LBL_Perso3.Content = "Equipier 3 : " + maClasseDeserialisee.people[3].name + " | Craft : " + maClasseDeserialisee.people[3].craft; // Affiche le nom de la troisième personne dans l'ISS
                    LBL_Perso4.Content = "Equipier 4 : " + maClasseDeserialisee.people[4].name + " | Craft : " + maClasseDeserialisee.people[4].craft; // Affiche le nom de la quatrième personne dans l'ISS
                    LBL_Perso5.Content = "Equipier 5 : " + maClasseDeserialisee.people[5].name + " | Craft : " + maClasseDeserialisee.people[5].craft; // Affiche le nom de la cinquième personne dans l'ISS
                    LBL_Perso6.Content = "Equipier 6 : " + maClasseDeserialisee.people[6].name + " | Craft : " + maClasseDeserialisee.people[6].craft; // Affiche le nom de la sixième personne dans l'ISS
                     
                    if (contenu.Contains("error"))
                    {
                        System.Windows.MessageBox.Show("Donnée non trouvée"); // Affichez un message d'erreur
                        return "ok"; 
                    }
                }
                return "OK";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception lors de GetMars : " + ex.Message); // Affichez un message d'erreur 
                return "KO";
            }
        }

        private void BTN_Video_ISS_Click(object sender, RoutedEventArgs e) // Lorsque le bouton BTN_Video_ISS est cliqué
        {
            try
            {
                // Specify the URL you want to open
                string url = "https://www.youtube.com/watch?v=P9C25Un7xaM";  // Replace this with the actual URL

                // Open the default web browser with the specified URL
                Process.Start(url);
            }
            catch (Exception ex) // Si une exeption est levée
            {
                Console.WriteLine("Exception in BTN_APOD_Click: " + ex.Message); // Affichez un message d'erreur
            }
        }
    }
}
