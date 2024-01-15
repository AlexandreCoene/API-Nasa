using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
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

using Api_Nasa.View;

namespace Api_Nasa
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

      
        public MainWindow()
        {  

            InitializeComponent(); 
            DisplayPageDaily(); // Affichez la page PageDaily

        }

        public void DisplayPageDaily() // Affichez la page PageDaily
        {
            Grid_Conteneur.Children.Clear(); // Nettoyez le contenu de la grille
            PageDaily pageDaily = new PageDaily(); // Créez une nouvelle instance de PageDaily
            Grid_Conteneur.Children.Add(pageDaily); // Ajoutez la page à la grille²
        }

        public void DisplayPageMars()
        {
            Grid_Conteneur.Children.Clear();
            View_Mars viewMars = new View_Mars();
            Grid_Conteneur.Children.Add(viewMars);
        }

        public void DisplayPageISS()
        {
            Grid_Conteneur.Children.Clear();
            View_Planet viewISS = new View_Planet();
            Grid_Conteneur.Children.Add(viewISS);
        }

        public void DisplayPageSuite()
        {
            Grid_Conteneur.Children.Clear();
            View_Last viewSuite = new View_Last();
            Grid_Conteneur.Children.Add(viewSuite);
        }

        public void BTN_Nasa_Click(object sender, RoutedEventArgs e)
        {
            DisplayPageDaily();

        }

        public void BTN_Mars_Click(object sender, RoutedEventArgs e)
        {
            DisplayPageMars();
        }
        
        private void BTN_Home_Click(object sender, RoutedEventArgs e) // Bouton ISS
        {
            DisplayPageISS(); // Affichez la page View_Planet 
        }

        private void BTN_Suite_Click(object sender, RoutedEventArgs e) // Bouton Suite
        {
            DisplayPageSuite(); // Affichez la page View_Last
        }

    }
}

