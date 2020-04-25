using PixDrive.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PixDrive
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1 : MasterDetailPage
    {
        public MasterDetailPage1()
        {
            InitializeComponent();
            List<ItrmList> listamenu = new List<ItrmList>(){
                new ItrmList()
                {
                    imagen= "pixhome.png",
                    titulo = "Inicio",
                    pagina = new MainPage()

                },
                  new ItrmList()
                {
                    imagen= "pixprof.png",
                    titulo = "Mi instructor",
                    pagina = new MainPage()

                },
                  new ItrmList()
                {
                    imagen= "pixsalir.png",
                    titulo = "Salir",
                    pagina = new MainPage()

                },
                   new ItrmList()
                {
                    imagen= "mundo.png",
                    titulo = "Acerca de",
                    pagina = new MainPage()

                },
            };
            listachida.ItemsSource = listamenu;

            this.Detail = new NavigationPage(new Perfil())
            {
            };
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ItrmList il = (ItrmList)e.SelectedItem;
            if(il.titulo == "Salir")
            {
                Application.Current.MainPage = new MainPage()
                {
                    
                };
            }
            else
            {
                this.Detail = new NavigationPage(il.pagina);
                IsPresented = false;
            }
        }
    }
}