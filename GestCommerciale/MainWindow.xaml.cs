using DevExpress.Xpf.Core;
using GestCommerciale.PL;
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


namespace GestCommerciale
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Déclaration des objets 
        Accuiel_window accuiel_Window = new Accuiel_window();
        Categories_window categories_window = new Categories_window();
        

        public MainWindow()
        {
            InitializeComponent();
            
        }

        public object Envirement { get; private set; }

        //Agrendir et Minimiser la fenêtre
        private void SimpleButton_Click(object sender, RoutedEventArgs e)
        {
            if (main_window.WindowState == WindowState.Normal)
            {
                main_window.WindowState = WindowState.Maximized;
            }
            else if(main_window.WindowState == WindowState.Maximized)
            {
                main_window.WindowState = WindowState.Normal;
            }
            
        }
        //Fermer l'application
        private void SimpleButton_Click_1(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        //Reduire la fenêtre
        private void SimpleButton_Click_2(object sender, RoutedEventArgs e)
        {
            main_window.WindowState = WindowState.Minimized;
        }
        //Charger la page "Accuiel"
        private void SimpleButton_Click_3(object sender, RoutedEventArgs e)
        {
            pnl_container.Children.Clear();
            pnl_container.Children.Add(accuiel_Window);

        }

        private void SimpleButton_Click_4(object sender, RoutedEventArgs e)
        {

        }
        //Collapse
        private void SimpleButton_Click_5(object sender, RoutedEventArgs e)
        {
            if (pnl_sidebar.Width == 280)
            {
                pnl_sidebar.Width = 100;
                //Cacher l'image
                pnl_image_cont.Visibility = Visibility.Collapsed;
                //Mettre margin pour le contenair principale
                Thickness margin = pnl_container.Margin;
                margin.Left = 100;
                pnl_container.Margin = margin;
            }
            else
            {
                pnl_sidebar.Width = 280;
                //afficher l'image
                pnl_image_cont.Visibility = Visibility.Visible;
                //Mettre margin pour le contenair principale
                Thickness margin = pnl_container.Margin;
                margin.Left = 281;
                pnl_container.Margin = margin;
            }
        }
        //Charger la page "Categories"
        private void SimpleButton_Click_6(object sender, RoutedEventArgs e)
        {
            pnl_container.Children.Clear ();
            pnl_container.Children.Add(categories_window);
        }
    }
}
