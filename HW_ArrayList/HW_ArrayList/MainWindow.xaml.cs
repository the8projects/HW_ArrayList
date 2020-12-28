using System;
using System.Collections;
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

namespace HW_ArrayList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayText;
        public MainWindow()
        {
            InitializeComponent();
            arrayText = new ArrayList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            arrayText.Add(txtValue.Text.Trim());
            MessageBox.Show("Value: '" + txtValue.Text + "' Added.");
            ClearText();
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (arrayText.Contains(txtValue.Text.Trim()))
            {
                arrayText.Remove(txtValue.Text.Trim());
                MessageBox.Show("Value: '" + txtValue.Text + "' Deleted.");
            }
            else
            {
                MessageBox.Show("This value does not contain in ArrayList.");
            }

            //Remove by index.
            //if (int.TryParse(txtValue.Text.Trim(), out int i))
            //{
            //    if (i >= 0 && i < arrayText.Count)
            //    {
            //        arrayText.RemoveAt(i);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Doesn't have this index in Arraylist.");
            //    }
            //}

            ClearText();
        }

        private void BtnShowAll_Click(object sender, RoutedEventArgs e)
        {
            int i = 1;

            if (arrayText.Count == 0)
            {
                MessageBox.Show("This ArrayList has no item.");
            }else if (arrayText.Count == 1)
            {
                MessageBox.Show("This ArrayList has " + arrayText.Count.ToString() + " item.");
            }
            else
            {
                MessageBox.Show("This ArrayList has " + arrayText.Count.ToString() + " items.");
            }
            
            foreach (string data in arrayText)
            {
                MessageBox.Show(i.ToString() + ") " + data);
                i++;
            }

            ClearText();
        }

        private void ClearText()
        {
            txtValue.Clear();
        }
    }
}
