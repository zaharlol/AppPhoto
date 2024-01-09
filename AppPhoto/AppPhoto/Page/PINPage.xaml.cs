using AppPhoto.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPhoto.Page
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PINPage : ContentPage
    {
        string pin;
        public static string FilePath { get; set; }

        public PINPage()
        {
            InitializeComponent();
            FilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Pin.txt");
            pin = File.ReadAllText(FilePath);
        }
        
        public void ManualButtonClicked(object sender, System.EventArgs e)
        {
            File.WriteAllText(FilePath, entryPin.Text);
            pin = File.ReadAllText(FilePath);
        }

        public void ButtonIn_Clicked(object sender, System.EventArgs e)
        {
            if (entryPin.Text == pin)
            {
                Navigation.PushAsync(new PhotoPage());
            }
            else
            {
                var infoMessage = new Label()
                {
                    Text = "Неверный пин!",
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    TextColor = Color.Red,
                    FontSize = 20,
                };
            stackL.Children.Add(infoMessage);
        }
        }
    }
}