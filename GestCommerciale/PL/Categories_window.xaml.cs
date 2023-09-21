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
using System.Data.Entity;
using GestCommerciale.PL.Fenêtres;
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

        Toast_notif toast_Notif = new Toast_notif();
        Methods methods = new Methods();


        public Categories_window()
        {
            InitializeComponent();


        }

        //Afficher la fenêtre d'ajoute des Categories
        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            ajouter_cat_wind.id = 0;
            ajouter_cat_wind.Show();
        }


        //Modification
        private void btn_modify_Click(object sender, RoutedEventArgs e)
        {
            //Récupèrer "Id" de la ligne selectionnée
            //int id = Convert.ToInt32(grid.GetFocusedRowCellValue("Id"));
            int id = 0;
            var row_result = db.Table_Categories.Where(x => x.Id == id).FirstOrDefault();

            db.Entry(row_result).Reload();

            ajouter_cat_wind.textbox_name.Text = row_result.Cat_Name.ToString();
            ajouter_cat_wind.imgEdit.Source = methods.LoadImage(row_result.Cat_img);
            ajouter_cat_wind.id = id;
            ajouter_cat_wind.Show();
        }



        //Supprimer les enregistrements
        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Récupèrer "Id" de la ligne selectionnée
                //int id = Convert.ToInt32(grid.GetFocusedRowCellValue("Id"));
                int id = 0;
                //Supprimer l'enregistrement dans la bdd a l'aide de "id"
                var row_result = db.Table_Categories.Where(x => x.Id == id).FirstOrDefault();
                db.Entry(row_result).State = EntityState.Deleted;
                db.SaveChanges();
                //Actualiser les données
                //LoadData();
                //Afficher le message dialog
                toast_Notif.label_msg.Content = "L'élément a été supprimer avec succée ...";
                toast_Notif.Show();
            }
            catch { }
        }



        //Actualiser les données
        private void btn_refresh_Click(object sender, RoutedEventArgs e)
        {
            //LoadData();
            //db.Table_Categories
            //db.Entry().Reload();
        }





        
                




    }
}
