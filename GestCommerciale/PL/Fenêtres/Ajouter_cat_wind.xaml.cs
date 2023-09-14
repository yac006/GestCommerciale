using System;
using System.Collections.Generic;
using System.IO;
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
using GestCommerciale.BL;
using GestCommerciale.PL.Toast_Notifications;
using System.Drawing.Imaging;

namespace GestCommerciale.PL.Fenêtres
{
    /// <summary>
    /// Logique d'interaction pour Ajouter_cat_wind.xaml
    /// </summary>
    public partial class Ajouter_cat_wind : Window
    {
        DB_Gest_ComEntities db = new DB_Gest_ComEntities();
        Table_Categories tb_categories = new Table_Categories();
        Methods methods = new Methods();
        Toast_notif toast_Notif = new Toast_notif();
        Dialog Dialog = new Dialog();
        int id = 0;


        public Ajouter_cat_wind()
        {
            InitializeComponent();
        }

        //Ajouter ou Modifier une "Categorie"
        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            //Verifier si "Ajouter" ou "Modifier"
            if (textbox_name.Text == "")
            {
                Dialog.Width = this.Width;
                Dialog.label_msg.Content = "Le Nom de Categorie est obligatoire !";
                Dialog.window_dialog.Show();

            }
            else
            {
                //Verifier si "Ajouter" ou "Modifier"
                if (id == 0)
                {
                    //image_cat.image.save(methods.ma, ImageFormat.Jpeg);


                    tb_categories.Cat_Name = textbox_name.Text;
                    tb_categories.Cat_img = methods.convert_byte();
                    db.Table_Categories.Add(tb_categories);
                    db.SaveChanges();

                    toast_Notif.label_msg.Content = "Categorie ajouter avec succée ...";
                    toast_Notif.Show();
                }
                else
                {
                    
                }
            }

        }
        //Fermeture de la fenêtre
        private void SimpleButton_Click_1(object sender, RoutedEventArgs e)
        {
            window_ajt_cat.Close();
        }

        private void window_ajt_cat_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            e.Cancel = true;
        }
    }
}
