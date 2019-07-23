using System;
using System.IO;
using Xamarin.Forms;

namespace Notes
{
    public partial class App : Application
    {
        public static string FolderPath { get; private set; }

        public App()
        {
            InitializeComponent(); 
            //iniciializar la carpeta de la aplicacion donde estan guardados los datos
            FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            //indicar en que pagina comeinza la nagvecion
            MainPage = new NavigationPage(new NotesPage());
        }
        // ...
    }
}