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

namespace QSTCreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ClosableTab theTabItem = new ClosableTab { Label = "asd" };
            tabControl.Items.Add(theTabItem);
            ClosableTab theTabItem1 = new ClosableTab { Label = "asd1" };
            tabControl.Items.Add(theTabItem1);
            theTabItem.Focus();
            ClosableTab theTabItem2 = new ClosableTab { Label = "asd2" };
            tabControl.Items.Add(theTabItem2);
        }

        private void Window_Activated(object sender, EventArgs e)
        {
        }

        private void sliderZoom_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var shift = e.NewValue % 25;
            if (shift == 0) return;
            if (shift > 12.5)
                shift -= 25;
            (sender as Slider).Value = e.NewValue - shift;
        }
    }
}
