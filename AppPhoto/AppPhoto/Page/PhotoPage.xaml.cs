using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Xamarin.Essentials.Permissions;

namespace AppPhoto.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhotoPage : ContentPage
    {
        string pin;
        public PhotoPage()
        {
            InitializeComponent();

            FileImageSource file = $"/storage/emulated/0/Pictures";
            var photo = new ImageCell()
            {
            };
        }

        private void buttonDelete_Clicked(object sender, EventArgs e)
        {

        }

        private void buttonNew_Clicked(object sender, EventArgs e)
        {

        }
    }
}
//$"/storage/emulated/0/Pictures";