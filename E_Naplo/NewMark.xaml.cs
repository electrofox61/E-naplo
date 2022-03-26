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
using System.Windows.Shapes;
using System.IO;


namespace E_Naplo
{
    /// <summary>
    /// Interaction logic for NewMark.xaml
    /// </summary>
    public partial class NewMark : Window
    {
        List<Jegyek> jegyek = new List<Jegyek>();

        public NewMark()
        {

            InitializeComponent();
        }

        private void getmark_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < jegyek.Count; i++)
            {
                foreach (var item in File.ReadAllLines( jegyek[i].Név + ".txt"))
                {
                    jegyek.Add(new Jegyek(item));
                }
            }
            grades.ItemsSource = jegyek;
        }
    }
}
