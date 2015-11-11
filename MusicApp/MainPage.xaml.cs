using MusicApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MusicApp
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private ObservableCollection<MenuItem> lista;

        public ObservableCollection<MenuItem>  Lista
        {
            get {
                if (lista == null) {
                    lista = new ObservableCollection<MenuItem>();

                    MenuItem item1 = new MenuItem() { Label="Álbunes", Icon= "Pictures" };
                    MenuItem item2 = new MenuItem() { Label = "Artistas", Icon = "People" };
                    MenuItem item3 = new MenuItem() { Label = "Canciones", Icon = "Audio" };
                    MenuItem item4 = new MenuItem() { Label = "Reproducción", Icon = "MusicInfo" };
                    MenuItem item5 = new MenuItem() { Label = "Configuración", Icon = "Setting" };

                    Lista.Add(item1);
                    Lista.Add(item2);
                    Lista.Add(item3);
                    Lista.Add(item4);
                    Lista.Add(item5);

                }

                return lista;

            }
            set { lista = value; }
        }

        private void click(object sender, RoutedEventArgs e)
        {
            if (Split.IsPaneOpen)
                Split.IsPaneOpen = false;
            else
                Split.IsPaneOpen = true;

        }
    }
}
