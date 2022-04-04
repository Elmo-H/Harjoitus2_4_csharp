using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Harjoitus2_4_csharp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            string value = radioButton.Content.ToString();
            result.Text = value;
        }

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            string value = radioButton.Content.ToString();
            result.Text = value;
        }

        private void radioButton3_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            string value = radioButton.Content.ToString();
            result.Text = value;
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
           if (checkBox1.IsChecked == true)
            {
                string checkBoxContent = checkBox1.Text;
            }
        }

        private void checkBox2_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void checkBox3_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioButton1_Unchecked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            result.Text = "";
        }

        private void radioButton2_Unchecked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            result.Text = "";
        }

        private void radioButton3_Unchecked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            result.Text = "";
        }

        private void checkBox1_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void checkBox2_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void checkBox3_Unchecked(object sender, RoutedEventArgs e)
        {

        }
    }
}
