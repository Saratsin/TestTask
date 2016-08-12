using System;
using MvvmCross.Core.ViewModels;

namespace Test.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private string _hello = "Hello MvvmCross";
        public string Hello
        {
            get { return _hello; }
            set { SetProperty(ref _hello, value); }
        }

        private byte _clickedTimes = 0;
        public byte ClickedTimes
        {
            get { return _clickedTimes; }
            set { SetProperty(ref _clickedTimes, value); }
        }

        public void ButtonClicked(object sender, EventArgs e)
        {
            ClickedTimes++;
        }

        public void SecondButtonClicked(object sender, EventArgs e)
        {
            ShowViewModel<SecondViewModel>();
        }
    }
}
