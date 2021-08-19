using NASA.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace NASA.Views
{
    /// <summary>
    /// Page to show the health profile.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoggedInPage : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoggedInPage" /> class.
        /// </summary>
        public LoggedInPage()
        {
            this.InitializeComponent();
            this.BindingContext = LoggedInPageViewModel.BindingContext;
        }
    }
}