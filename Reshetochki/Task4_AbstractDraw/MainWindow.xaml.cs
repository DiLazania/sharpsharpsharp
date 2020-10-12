using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace Task4_AbstractDraw
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Figure fig;
        public MainWindow()
        {
            InitializeComponent();
        }
        

        private void GenerateBtn_Click(object sender, RoutedEventArgs e)
        {
            var rn = new Random();
            switch (rn.Next(1, 4))
            {
                case 1: 
                    fig = new Rect();
                    gen.Content = "Generated";
                    break;
            }
        }
        
        private void DrawBtn_Click(object sender, RoutedEventArgs e)
        {
            fig.Draw(canv);
        }
    }
}
