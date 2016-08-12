using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using UIKit;

namespace Test.IOS
{
    public partial class SecondView : MvxViewController
    {
        public SecondView() : base("SecondView", null)
        {
        }
    }
}