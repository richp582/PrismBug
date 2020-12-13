using System;
using Prism.Mvvm;

namespace PrismBug.ViewModels
{
    public class PageBViewModel : BindableBase
    {
        private string _test;
        public string Test
        {
            get => _test;
            set => SetProperty(ref _test, value);
        }
        public PageBViewModel()
        {
            Test = "This is Page B";
        }
    }
}
