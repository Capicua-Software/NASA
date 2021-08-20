using NASA.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NASA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhotoPage : ContentPage
    {
        //public dynamic publicPhoto;
        public string imgPath;
        public PhotoPage()
        {
            InitializeComponent();
            NextStep.IsVisible = false;
            VerifyFace.IsVisible = false;
            //CameraButton.Clicked += CameraButton_Clicked;
        }

        private async void CameraButton_Clicked(object sender, EventArgs e)
        {
            var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() { });

            if (photo != null)
            {
                PhotoImage.Source = ImageSource.FromStream(() => { return photo.GetStream(); });
                imgPath = photo.Path;
                VerifyFace.IsVisible = true;
                  //await App.Current.MainPage.DisplayAlert("La foto está miop", "Mete mano miop jeje duro!!! banda para ti", "Ok");
            }

        }

        private async void NextStepBtn_Clicked(object sender, EventArgs e)
        {


        }

        private async void VerifyFaceBtn_Clicked(object sender, EventArgs e)
        {
            FAuth obj = new FAuth();
            await obj.GetImgUrl(imgPath);

            string a = "";

        }

    }

}