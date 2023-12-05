using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassBIZ ClassBIZ = new ClassBIZ();
        public MainWindow()
        {

            InitializeComponent();

        }


        private void Opgave12_OnClick_(object sender, RoutedEventArgs e)
        {
            ListBoxRes.Items.Clear(); // Clear the listbox
            ClassBIZ.Number4711(ListBoxRes); // Call the method from ClassBIZ.cs
        }

        private void Opgave13_OnClick_(object sender, RoutedEventArgs e)
        {
            ListBoxRes.Items.Clear(); // Clear the listbox
            ClassBIZ.RandomNumbers(ListBoxRes); // Call the method from ClassBIZ.cs
        }
    }
}
