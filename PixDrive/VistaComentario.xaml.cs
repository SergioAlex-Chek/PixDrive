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
	public partial class VistaComentario : ContentView
	{
		public VistaComentario (Modelos.Instructor instructor)
		{
			InitializeComponent ();
            txtIniciales.Text = instructor.idInstructor.ToString();
            txtComentario.Text = instructor.NOMBREINSTRUCTOR;
		}
	}
}