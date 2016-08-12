using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;

namespace Test.IOS.Views
{
    public partial class FirstView : MvxViewController
    {
        public FirstView() : base("FirstView", null)
        { }

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

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<FirstView, Core.ViewModels.FirstViewModel>();
            set.Bind(Label).To(vm => vm.ClickedTimes);
            set.Bind(TextField).To(vm => vm.Hello);
            set.Apply();

            var button1 = UIButton.FromType(UIButtonType.Custom);
            button1.Frame = new CoreGraphics.CGRect(0, 200, 320, 20);
            button1.SetTitle("Counter button", UIControlState.Normal);
            button1.BackgroundColor = UIColor.Cyan;
            button1.TouchUpInside += ViewModel.ButtonClicked;

            var button2 = UIButton.FromType(UIButtonType.Custom);
            button2.Frame = new CoreGraphics.CGRect(0, 300, 320, 20);
            button2.SetTitle("Go to second view", UIControlState.Normal);
            button2.BackgroundColor = UIColor.Cyan;
            button2.TouchUpInside += ViewModel.SecondButtonClicked;

            View.AddSubview(button1);
            View.AddSubview(button2);
        }
    }
}
