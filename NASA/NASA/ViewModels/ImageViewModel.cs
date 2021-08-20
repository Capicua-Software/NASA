using NASA.Models;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace NASA.ViewModels
{
    public class ImageViewModel:ImageModel
    {
        public Command CaptureCommand { get; set; }

        public ImageViewModel()
        {
           // TakePic();
            CaptureCommand = new Command(TakePic);
        }

        public async void TakePic()
        {
            var camera = new StoreCameraMediaOptions();
            camera.PhotoSize = PhotoSize.Full;
            camera.SaveToAlbum = true;

            var picture = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(camera);

            if (picture != null)
            {
                Pic = ImageSource.FromStream(() => {
                    return picture.GetStream(); 
                });
            }

        }
    }
}
