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
using System.Collections;
using System.Security;

namespace PATHEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string VAR_NAME = "path";
        
        private string[] values;
        private ListBoxItem selectedItem;
        private string fullVarValue;

        public MainWindow()
        {
            InitializeComponent();

            valuesList.SelectionChanged += ValuesList_SelectionChanged;
            valueTextBox.TextChanged += ValueTextBox_TextChanged;
            writeButton.Click += WriteButton_Click;
            updateButton.Click += UpdateButton_Click;
            addValue.Click += AddValue_Click;
            removeValue.Click += RemoveValue_Click;

            ReadValues();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            ReadValues();
        }

        private void WriteButton_Click(object sender, RoutedEventArgs e)
        {
            WriteValues();
        }

        private void ValueTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (selectedItem != null)
            {
                selectedItem.Content = valueTextBox.Text;
                updateFullValue();
            }
        }

        private void ValuesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedItem = valuesList.SelectedValue as ListBoxItem;
            if (selectedItem != null)
            {
                
                valueTextBox.Text = selectedItem.Content as String;
            } else
            {
                valueTextBox.Text = "";
            }
        }

        private void AddValue_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem item = new ListBoxItem();
            item.Content = "";
            valuesList.Items.Add(item);
            valuesList.SelectedIndex = valuesList.Items.Count - 1;
            valuesList.ScrollIntoView(item);
        }

        private void RemoveValue_Click(object sender, RoutedEventArgs e)
        {
            if (selectedItem != null)
            {
                valuesList.Items.Remove(selectedItem);
                valuesList.SelectedIndex = valuesList.Items.Count - 1;
            }
        }

        private void updateFullValue()
        {
            fullVarValue = "";
            ListBoxItem item;
            for (int i = 0, l = valuesList.Items.Count; i < l; i++)
            {
                item = valuesList.Items.GetItemAt(i) as ListBoxItem;
                if (item != null && (item.Content as string).Length > 0)
                {
                    fullVarValue += item.Content + ";";
                }
            }
            fullValueTextBox.Text = fullVarValue;
        }

        private void ReadValues()
        {
            string varValue = Environment.GetEnvironmentVariable(VAR_NAME, EnvironmentVariableTarget.Machine);
            if (varValue != null && varValue.Length > 0)
            {
                values = varValue.Split(';');
                List<string> tmp = new List<string>();
                foreach (string val in values)
                {
                    if (val != null && val.Length > 0)
                    {
                        tmp.Add(val);
                    }
                }
                values = tmp.ToArray();
                if (values.Length > 0)
                {
                    PrintValues();
                    updateFullValue();
                }
            }
        }

        private void PrintValues()
        {
            valuesList.Items.Clear();
            ListBoxItem item;
            foreach (string value in values)
            {
                item = new ListBoxItem();
                item.Content = value;
                valuesList.Items.Add(item);
            }
        }

        private void WriteValues()
        {
            try
            {
                Environment.SetEnvironmentVariable(VAR_NAME, fullVarValue, EnvironmentVariableTarget.Machine);
            } catch (SecurityException exc)
            {
                MessageBox.Show("You do not have permissions to write PATH variable");
            } 
        }
    }
}
