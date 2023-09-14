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
using GestCommerciale;
using DevExpress.Xpf.Grid;
using DevExpress.Data.Linq;
using System.Data.Entity;
using GestCommerciale.PL.Fenêtres;

namespace GestCommerciale.PL
{
    /// <summary>
    /// Logique d'interaction pour Categories_window.xaml
    /// </summary>
    public partial class Categories_window : UserControl
    {
        Ajouter_cat_wind ajouter_cat_wind = new Ajouter_cat_wind();

        public Categories_window()
        {
            InitializeComponent();
            var context = new DB_Gest_ComEntities();
            var source = new EntityServerModeSource
            {
                KeyExpression = nameof(Table_Categories.Id),
                QueryableSource = context.Table_Categories.AsNoTracking()
            };

        }
        //Afficher la fenêtre d'ajoute des Categories
        private void SimpleButton_Click(object sender, RoutedEventArgs e)
        {
            ajouter_cat_wind.Show();
        }
    }
}
