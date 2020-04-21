using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    { 
        public App()
        {
            DispatcherUnhandledException += (sender, args) =>
            {
                Console.WriteLine("Test7");
            };

            TaskScheduler.UnobservedTaskException += (sender, args) =>
            {
                Console.WriteLine("Test7");
            };
        }

        void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            // Process unhandled exception
            Console.WriteLine("Test6");


            // Prevent default unhandled exception processing
            e.Handled = true;
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            this.Dispatcher.UnhandledException += (sender, args) =>
            {
                Console.WriteLine("Test1");
            };

            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                Console.WriteLine("Test2");
            };

            Application.Current.DispatcherUnhandledException += (sender, args) =>
            {
                Console.WriteLine("Test3");
            };

            AppDomain.CurrentDomain.FirstChanceException += (sender, args) =>
            {
                Console.WriteLine("Test4");
            };

            Application.Current.Dispatcher.UnhandledException += (sender, args) =>
            {
                Console.WriteLine("Test5");
            };
        }
    }
}
