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
        }
    }
}