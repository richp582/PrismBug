using System;
using Prism.Mvvm;

namespace PrismBug.ViewModels
{
    public class PageAViewModel: BindableBase
    {
        private string _test;
        public string Test
        {
            get => _test;
            set => SetProperty(ref _test, value);
        }

        public PageAViewModel()
        {
            Test = "This is Page A";
        }
    }
}
