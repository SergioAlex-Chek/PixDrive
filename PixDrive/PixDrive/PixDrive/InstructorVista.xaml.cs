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
	public partial class InstructorVista : ContentView
	{
		public InstructorVista ()
		{
			InitializeComponent ();

            
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Application.Current.MainPage  = new MasterDetailPage1();
        }
    }
}