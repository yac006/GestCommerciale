using Syncfusion.Windows.Shared;
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
using GestCommerciale.PL;

namespace GestCommerciale.PL
{
    /// <summary>
    /// Logique d'interaction pour Accuiel_window.xaml
    /// </summary>
    public partial class Accuiel_window : UserControl
    {
        //Carousel carousel = new Carousel() { Height = 100 , Width = 200 }; 

        public Accuiel_window()
        {
            InitializeComponent();

            loadCarousel();
            

        }

        private void loadCarousel()
        {
            

            foreach (Image img in images())
            {
                carousel_menu.Items.Add(new CarouselItem() { Content = new Viewbox() { Child = img } });
            }
            
           
        }

        private Image[] images()
        {
            Image image = new Image();
            Image image1 = new Image();
            Image image2 = new Image();
            Image image3 = new Image();
            Image image4 = new Image();
            Image image5 = new Image();
            Image image6 = new Image();
            Image image7 = new Image();

            BitmapImage bitimg1 = new BitmapImage(new Uri("C:\\Users\\Yacine\\source\\repos\\GestCommerciale\\GestCommerciale\\PL\\img\\icons8-type-de-peau-7-au-premier-plan-de-la-conférence-96.png", UriKind.RelativeOrAbsolute));
            BitmapImage bitimg2 = new BitmapImage(new Uri("C:\\Users\\Yacine\\source\\repos\\GestCommerciale\\GestCommerciale\\PL\\img\\icons8-ajouter-une-propriété-96.png", UriKind.RelativeOrAbsolute));
            BitmapImage bitimg3 = new BitmapImage(new Uri("C:\\Users\\Yacine\\source\\repos\\GestCommerciale\\GestCommerciale\\PL\\img\\icons8-consumption-96.png", UriKind.RelativeOrAbsolute));
            BitmapImage bitimg4 = new BitmapImage(new Uri("C:\\Users\\Yacine\\source\\repos\\GestCommerciale\\GestCommerciale\\PL\\img\\icons8-fournisseur-96.png", UriKind.RelativeOrAbsolute));
            BitmapImage bitimg5 = new BitmapImage(new Uri("C:\\Users\\Yacine\\source\\repos\\GestCommerciale\\GestCommerciale\\PL\\img\\icons8-insérer-un-tableau-96.png", UriKind.RelativeOrAbsolute));
            BitmapImage bitimg6 = new BitmapImage(new Uri("C:\\Users\\Yacine\\source\\repos\\GestCommerciale\\GestCommerciale\\PL\\img\\icons8-type-de-peau-7-au-premier-plan-de-la-conférence-96.png", UriKind.RelativeOrAbsolute));
            BitmapImage bitimg7 = new BitmapImage(new Uri("C:\\Users\\Yacine\\source\\repos\\GestCommerciale\\GestCommerciale\\PL\\img\\icons8-fournisseur-96.png", UriKind.RelativeOrAbsolute));
            BitmapImage bitimg8 = new BitmapImage(new Uri("C:\\Users\\Yacine\\source\\repos\\GestCommerciale\\GestCommerciale\\PL\\img\\icons8-insérer-un-tableau-96.png", UriKind.RelativeOrAbsolute));

            image.Source = bitimg1 as ImageSource;
            image1.Source = bitimg2 as ImageSource;
            image2.Source = bitimg3 as ImageSource;
            image3.Source = bitimg4 as ImageSource;
            image4.Source = bitimg5 as ImageSource;
            image5.Source = bitimg6 as ImageSource;
            image6.Source = bitimg7 as ImageSource;
            image7.Source = bitimg8 as ImageSource;

            Image[]  imgs = { image, image1, image2, image3, image4, image5, image6, image7};


            return imgs;
        }
    }
}
