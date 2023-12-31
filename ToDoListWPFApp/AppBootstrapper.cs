using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Windows;
using ToDoListWPFApp.ViewModels;

namespace ToDoListWPFApp
{
    public class AppBootstrapper : BootstrapperBase
    {
        private SimpleContainer _container;

        public AppBootstrapper()
        {
            Initialize();
        }

        protected override void Configure()
        {
            _container = new SimpleContainer();

            // Register Singletons (e.g., Services and Managers that should have a single instance)
            _container.Singleton<IWindowManager, WindowManager>();

            // Register per-instance types (e.g., View models)
            _container.PerRequest<ShellViewModel>();

        }

        protected override object GetInstance(Type service, string key)
        {
            return _container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewForAsync<ShellViewModel>();
        }
    }
}
