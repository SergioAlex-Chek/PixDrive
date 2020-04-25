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
	public partial class Perfil : ContentPage
	{
		public Perfil ()
		{
			InitializeComponent ();

            for (int i = 0; i < 5; i++)
            {
                sl.Children.Add(new VistaComentario(new Modelos.Instructor() { idInstructor = 1, NOMBREINSTRUCTOR = "Hola que haces aqui va el comentario del instructor" }));
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            slComentarios.BackgroundColor = Color.FromHex("1eaac1");
            slNotas.BackgroundColor = Color.Transparent;
            lblNotas.TextColor = Color.FromHex("1eaac1");
            sl.IsVisible = true;
            slN2.IsVisible = false;
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            slNotas.BackgroundColor = Color.FromHex("1eaac1");
            slComentarios.BackgroundColor = Color.Transparent;
            lblComentarios.TextColor = Color.FromHex("1eaac1");
            slN2.IsVisible = true;
            sl.IsVisible = false;
        }
    }
}