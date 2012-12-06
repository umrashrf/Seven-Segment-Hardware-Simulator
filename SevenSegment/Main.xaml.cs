using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SevenSegment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            var txtInput = sender as TextBox;
            if (txtInput.Text != "0" && txtInput.Text != "1")
                txtInput.Text = "1";
            txtInput.SelectAll();

            if (txtA != null && txtB != null && txtC != null && txtD != null && txtE != null && txtF != null && txtG != null && txtH != null)
                ResetSegment();
        }

        private void txtInput_GotFocus(object sender, RoutedEventArgs e)
        {
            var txtInput = sender as TextBox;
            txtInput.SelectAll();
        }

        private void txtInput_KeyUp(object sender, KeyEventArgs e)
        {
            var txtInput = sender as TextBox;
            if (e.Key == Key.Up || e.Key == Key.Down)
            {
                var resultant = txtInput.Text == "0";
                txtInput.Text = resultant ? "1" : "0";
            }
        }

        private void ResetSegment()
        {
            SolidColorBrush dimColor = new SolidColorBrush(Color.FromArgb(54, 211, 211, 211));

            SetLineColor(lnA, txtA.Text == "0" ? Brushes.Red : dimColor);
            SetLineColor(lnB, txtB.Text == "0" ? Brushes.Red : dimColor);
            SetLineColor(lnC, txtC.Text == "0" ? Brushes.Red : dimColor);
            SetLineColor(lnD, txtD.Text == "0" ? Brushes.Red : dimColor);
            SetLineColor(lnE, txtE.Text == "0" ? Brushes.Red : dimColor);
            SetLineColor(lnF, txtF.Text == "0" ? Brushes.Red : dimColor);
            SetLineColor(lnG, txtG.Text == "0" ? Brushes.Red : dimColor);
            SetLineColor(lnH, txtH.Text == "0" ? Brushes.Red : dimColor);
        }

        private void SetLineColor(Shape ln, Brush color)
        {
            ln.Fill = color;
            ln.Stroke = color;
        }

        private void txtLink_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Clipboard.SetText("info@umairashraf.me", TextDataFormat.Text);
            MessageBox.Show("The email address is copied to the clipboard please paste it anywhere you wish.", "Copied", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
