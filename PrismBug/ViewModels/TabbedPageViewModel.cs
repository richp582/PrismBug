using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Navigation;

namespace PrismBug.ViewModels
{
    public class TabbedPageViewModel : BindableBase, IInitializeAsync
    {
        public TabbedPageViewModel()
        {
        }

        public async Task InitializeAsync(INavigationParameters parameters)
        {
            Debug.WriteLine("Called");
            await Task.CompletedTask;
        }
    }
}
