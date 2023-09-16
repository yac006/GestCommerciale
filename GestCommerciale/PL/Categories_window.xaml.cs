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
            var context = new DB_Gest_ComEntities1();
            var source = new EntityServerModeSource
            {
                KeyExpression = nameof(Table_Categories.Id),
                QueryableSource = context.Table_Categories.AsNoTracking()
            };
            LoadData();

        }
        //Afficher la fenêtre d'ajoute des Categories
        private void SimpleButton_Click(object sender, RoutedEventArgs e)
        {
            ajouter_cat_wind.id = 0;
            ajouter_cat_wind.Show();
        }
        DB_Gest_ComEntities1 _Context;

        public void LoadData()
        {
            _Context = new DB_Gest_ComEntities1();
            grid.ItemsSource = _Context.Table_Categories.ToList();
        }

        void OnValidateRow(object sender, GridRowValidationEventArgs e)
        {
            var row = (Table_Categories)e.Row;
            if (e.IsNewItem)
                _Context.Table_Categories.Add(row);
            _Context.SaveChanges();
        }

        void OnValidateRowDeletion(object sender, GridValidateRowDeletionEventArgs e)
        {
            var row = (Table_Categories)e.Rows.Single();
            _Context.Table_Categories.Remove(row);
            _Context.SaveChanges();
        }

        void OnDataSourceRefresh(object sender, DataSourceRefreshEventArgs e) { LoadData(); }
        
        //Actualiser les données
        private void SimpleButton_Click_1(object sender, RoutedEventArgs e)
        {     
            LoadData();
        }
    }
}
