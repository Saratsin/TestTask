using Android.App;
using Android.OS;
using Android.Widget;
using MvvmCross.Droid.Views;

namespace Test.Android.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : MvxActivity
    {
        protected new Core.ViewModels.FirstViewModel ViewModel
        {
            get
            {
                return (Core.ViewModels.FirstViewModel)base.ViewModel;
            }
            set
            {
                base.ViewModel = value;
            }
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
            var button1 = FindViewById<Button>(Resource.Id.button1);
            button1.Click += ViewModel.ButtonClicked;
            var button2 = FindViewById<Button>(Resource.Id.button2);
            button2.Click += ViewModel.SecondButtonClicked;
        }
    }
}
