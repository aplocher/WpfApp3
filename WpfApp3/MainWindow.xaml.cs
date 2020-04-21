using System;
using System.Windows;

namespace WpfApp3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var t = new TestViewModel();
            this.DataContext = t;

            // Uncommenting either of these lines WILL cause the exception to show up in the Events in App.xaml.cs

            //t.TestProp = "Hello";

            //throw new Exception("Test Exceptionnnn");
        }
    }

    public class TestViewModel
    {
        private string testProp;

        public string TestProp
        {
            get => testProp;
            set
            {
                testProp = value;
                throw new Exception("Test Exception");
            }
        }
    }
}
