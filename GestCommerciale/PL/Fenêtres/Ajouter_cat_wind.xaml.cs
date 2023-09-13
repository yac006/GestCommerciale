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
using System.Windows.Shapes;

namespace GestCommerciale.PL.Fenêtres
{
    /// <summary>
    /// Logique d'interaction pour Ajouter_cat_wind.xaml
    /// </summary>
    public partial class Ajouter_cat_wind : Window
    {
        DB_Gest_ComEntities db = new DB_Gest_ComEntities();
        public Ajouter_cat_wind()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
