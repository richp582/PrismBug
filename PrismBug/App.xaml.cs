using System;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using PrismBug.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrismBug
{
    public partial class App : PrismApplication
    {
        public App() : this(null)
        {
        }

        public App(IPlatformInitializer initializer)
            : this(initializer, false)
        {
        }

        public App(IPlatformInitializer initializer, bool setFormsDependencyResolver)
                   : base(initializer, setFormsDependencyResolver)
        {
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<Pages.TabbedPage, ViewModels.TabbedPageViewModel>();

            containerRegistry.RegisterForNavigation<LoginPage, ViewModels.LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<PageA, ViewModels.PageAViewModel>();
            containerRegistry.RegisterForNavigation<PageB, ViewModels.PageBViewModel>();
        }

        protected override void OnInitialized()
        {
            
            InitializeComponent();
            NavigationService.NavigateAsync(new Uri("/NavigationPage/LoginPage", UriKind.Absolute));
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
