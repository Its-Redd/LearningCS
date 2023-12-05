using System;
using System.Windows.Controls;

namespace WpfApp1
{
    internal class ClassBIZ
    {
        public ClassBIZ() // Constructor
        {

        }

        public void Number4711(ListBox listBox) // Method to add numbers to the listbox
        {
            int count = 4737;
            for (int i = 4711; i < count; i++)
            {
                listBox.Items.Add(i.ToString());
            }

        }

        public void RandomNumbers(ListBox listBox)
        {
            Random random = new Random(); // Create a new random object

            for (int i = 0; i < 25; i++) // Loop 25 times
            {
                listBox.Items.Add(random.Next(100000, 1000000)); // Add a random number between 100.000 and 1.000.000 to the listbox
            }
        }

        public void RandomNumbersSorted(ListBox listBox)
        {
            Random random = new Random(); // Create a new random object

            for (int i = 0; i < 25; i++) // Loop 25 times
            {
                listBox.Items.Add(random.Next(100000, 1000000)); // Add a random number between 100.000 and 1.000.000 to the listbox
            }

            listBox.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("Content", System.ComponentModel.ListSortDirection.Ascending)); // Sort the listbox
        }
    }
}
