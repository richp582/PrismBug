using System;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace PrismBug.ViewModels
{
    public class LoginPageViewModel: BindableBase, IInitializeAsync
   {
        private string _test;
        public string Test
        {
            get => _test;
            set => SetProperty(ref _test, value);
        }

        private readonly INavigationService _navigationService;

        public DelegateCommand SkipCommand { get; set; }

        public LoginPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            Test = "Wait";
            SkipCommand = new DelegateCommand(async () => await OnSkipCommand());
        }

        public async Task InitializeAsync(INavigationParameters parameters)
        {
            Test = "Loaded";
            await Task.CompletedTask;
        }

        private async Task OnSkipCommand()
        {
            var r = await _navigationService.NavigateAsync(new Uri("/NavigationPage/TabbedPage?selectedTab=PageA", UriKind.Absolute));
        }
    }
}
