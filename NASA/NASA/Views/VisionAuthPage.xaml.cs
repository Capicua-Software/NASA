using NASA.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace NASA.Views
{
    /// <summary>
    /// Page to display on-boarding gradient with animation
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VisionAuthPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VisionAuthPage" /> class.
        /// </summary>
        public VisionAuthPage()
        {
            this.InitializeComponent();
            CameraButton.Clicked += CameraButton_Clicked;
            //BindingContext = new ImageViewModel();
            
        }

        void TakePic(object sender, EventArgs args)
        {
            ImageViewModel instance = new ImageViewModel();
            instance.TakePic();
        }

        private async void CameraButton_Clicked(object sender, EventArgs e)
        {
            var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() { });

            if (photo != null)
                PhotoImage.Source = ImageSource.FromStream(() => { return photo.GetStream(); });
        }

    }
}