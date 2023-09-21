using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Syncfusion.Licensing;


namespace GestCommerciale
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        
        public App()
        {
            //Register Syncfusion license
            SyncfusionLicenseProvider.RegisterLicense("MjcxMzk3M0AzMjMzMmUzMDJlMzBlelU1THJ6YkNMRDFtekNjQUFEdEVSQnJEKzlja0ZPbk9TS0xjYU1vRlhRPQ==");
        }
    }
}
