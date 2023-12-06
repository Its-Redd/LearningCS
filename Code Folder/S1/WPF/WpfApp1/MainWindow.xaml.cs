using BIZ;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        ClassBIZ BIZ; // Create a new instance of ClassBIZ
        public MainWindow()
        {
            InitializeComponent();

            BIZ = new ClassBIZ(); // Initialize the instance of ClassBIZ
        }

        private void ButtonClicked(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender; // Create a new button object
            Menu(int.Parse(button.Tag.ToString())); // Call the menu method with the tag of the button
        }

        private void Menu(int inKey)
        {
            ClearListBox(ListBoxRes); // Clear the listbox
            switch (inKey)
            {
                case 1:
                    BIZ.Number4711(ListBoxRes); // Call the method Number4711 from ClassBIZ
                    break;
                case 2:
                    BIZ.RandomNumbers(ListBoxRes); // Call the method RandomNumbers from ClassBIZ
                    break;
                case 3:
                    BIZ.RandomNumbersSorted(ListBoxRes); // Call the method RandomNumbersSorted from ClassBIZ
                    break;
                case 4:
                    BIZ.SortedAndUnsorted(ListBoxRes); // Call the method SortedAndUnsorted from ClassBIZ
                    break;
                case 5:
                    BIZ.RandomNumbersAVG(ListBoxRes); // Call the method RandomNumberAVG
                    break;
                case 6:
                    BIZ.SortedRandomNumbersAVG(ListBoxRes);
                    break;
                case 7:
                    ListBoxRes.ItemsSource = BIZ.SortedRandomNumbersAVGlist();
                    break;
                case 8:
                    BIZ.EvenOrOdd(ListBoxRes);
                    break;
                case 9:
                    MessageBox.Show("Opgave 10 er under opbygning", "Idc, skriv fejl, idk taber");
                    break;
                default:
                    break;

            }
        }

        private void ClearListBox(ListBox listBox)
        {
            if (listBox != null)
            {
                listBox.ItemsSource = null;
            }
            listBox.Items.Clear();
        }
    }
}
