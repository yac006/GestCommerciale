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
using DevExpress.XtraRichEdit.Fields;
using GestCommerciale.PL.Toast_Notifications;
using GestCommerciale.BL;

namespace GestCommerciale.PL
{
    /// <summary>
    /// Logique d'interaction pour Categories_window.xaml
    /// </summary>
    public partial class Categories_window : UserControl
    {
        Ajouter_cat_wind ajouter_cat_wind = new Ajouter_cat_wind();
        
        DB_Gest_ComEntities1 db = new DB_Gest_ComEntities1();
        Table_Categories table_Categories = new Table_Categories();

        Toast_notif toast_Notif = new Toast_notif();

        Methods methods = new Methods();

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
        //Supprimer les enregistrements
        private void SimpleButton_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                //Récupèrer "Id" de la ligne selectionnée
                int id = Convert.ToInt32(grid.GetFocusedRowCellValue("Id"));
                //Supprimer l'enregistrement dans la bdd a l'aide de "id"
                var row_result = db.Table_Categories.Where(x => x.Id == id).FirstOrDefault();
                db.Entry(row_result).State = EntityState.Deleted;
                db.SaveChanges();
                //Actualiser les données
                LoadData();
                //Afficher le message dialog
                toast_Notif.label_msg.Content = "L'élément a été supprimer avec succée ...";
                toast_Notif.Show();
            }
            catch { }
           





        }

        private void btn_modify_Click(object sender, RoutedEventArgs e)
        {
            //Récupèrer "Id" de la ligne selectionnée
            int id = Convert.ToInt32(grid.GetFocusedRowCellValue("Id"));

            var row_result = db.Table_Categories.Where(x => x.Id == id).FirstOrDefault();

            ajouter_cat_wind.textbox_name.Text = row_result.Cat_Name.ToString();
            ajouter_cat_wind.imgEdit.Source = methods.LoadImage(row_result.Cat_img);

            ajouter_cat_wind.Show();




        }
    }
}
