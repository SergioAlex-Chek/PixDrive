using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PixDrive
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            for(int i = 0; i < 10; i++)
            {
                sl.Children.Add(new InstructorVista());
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (paso0.IsVisible)
            {
                paso2.IsVisible = false;
                paso1.IsVisible = true;
                paso0.IsVisible = false;
                pasos.Source = "pasouno.png";
                imagenes.IsVisible = true;
            }
            else if(paso1.IsVisible)
            {
                paso2.IsVisible = true;
                paso1.IsVisible = false;
                paso0.IsVisible = false;
                pasos.Source = "pasodos.png";
            }
            else if (paso2.IsVisible)
            {
                paso3.IsVisible = true;
                paso2.IsVisible = false;
                boton.IsVisible = false;
                paso0.IsVisible = false;
                pasos.Source = "pasotres.png";
            }
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

            slComentarios.BackgroundColor = Color.FromHex("1eaac1");
            slNotas.BackgroundColor = Color.Transparent;
            lblNotas.TextColor = Color.FromHex("1eaac1");
            usrInstructor.IsVisible = true;
            usrAlumno.IsVisible = false;
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            slNotas.BackgroundColor = Color.FromHex("1eaac1");
            slComentarios.BackgroundColor = Color.Transparent;
            lblComentarios.TextColor = Color.FromHex("1eaac1");
            usrAlumno.IsVisible = true;
            usrInstructor.IsVisible = false;
        }
    }
}
