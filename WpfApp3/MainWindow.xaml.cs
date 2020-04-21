using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
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
            throw new Exception("Test Exceptionnnn");
        }
    }
}
}
