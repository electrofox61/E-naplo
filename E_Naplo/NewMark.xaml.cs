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
            
            selectclass.Items.Add("9A");
            selectclass.Items.Add("9B");
            selectclass.Items.Add("9C");
            selectclass.Items.Add("10A");
            selectclass.Items.Add("10B");
            selectclass.Items.Add("10C");
            selectclass.Items.Add("11A");
            selectclass.Items.Add("11B");
            selectclass.Items.Add("11C");
            selectclass.Items.Add("12A");
            selectclass.Items.Add("12B");
            selectclass.Items.Add("12C");

        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            foreach (var item in File.ReadAllLines("jegyek.txt"))
            {
                jegyek.Add(new Jegyek(item));
            }
            grades.ItemsSource = jegyek;

        }

        private void averagebutton_Click(object sender, RoutedEventArgs e)
        {/*
            if (selectclass.Text == "9A")
            {
                grades.Items.Refresh();
                var averagevar = jegyek
                    .Where(x => x.Név == selectclass.Text)
                    .Average(x => x.Osztályzat)
                    .Select(x => new { Név = x.Név, Osztály = x.Osztály, Évfolyam = x.Évfolyam, Osztályzat = x.Osztályzat })
                    .ToList();
                grades.ItemsSource = averagevar;

            }
            else if (selectclass.Text == "9B")
            {
                grades.Items.Refresh();
                var averagevar = jegyek
                    .Where(x => x.Évfolyam == selectclass.Text)
                    .Average(x => x.Osztályzat)
                    .Select(x => new { Név = x.Név, Osztály = x.Osztály, Évfolyam = x.Évfolyam, Osztályzat = x.Osztályzat })
                    .ToList();
                grades.ItemsSource = averagevar;
            }
            else if (selectclass.Text == "9C")
            {
                grades.Items.Refresh();
                var averagevar = jegyek
                    .Where(x => x.Osztály == selectclass.Text)
                    .Average(x => x.Osztályzat)
                    .Select(x => new { Név = x.Név, Osztály = x.Osztály, Évfolyam = x.Évfolyam, Osztályzat = x.Osztályzat })
                    .ToList();
                grades.ItemsSource = averagevar;
            }
            else if (selectclass.Text == "10A")
            {
                grades.Items.Refresh();
                var averagevar = jegyek
                    .Where(x => x.Osztály == selectclass.Text)
                    .Average(x => x.Osztályzat)
                    .Select(x => new { Név = x.Név, Osztály = x.Osztály, Évfolyam = x.Évfolyam, Osztályzat = x.Osztályzat })
                    .ToList();
                grades.ItemsSource = averagevar;
            }
            else if (selectclass.Text == "10B")
            {
                grades.Items.Refresh();
                var averagevar = jegyek
                    .Where(x => x.Osztály == selectclass.Text)
                    .Average(x => x.Osztályzat)
                    .Select(x => new { Név = x.Név, Osztály = x.Osztály, Évfolyam = x.Évfolyam, Osztályzat = x.Osztályzat })
                    .ToList();
                grades.ItemsSource = averagevar;
            }
            else if (selectclass.Text == "10C")
            {
                grades.Items.Refresh();
                var averagevar = jegyek
                    .Where(x => x.Osztály == selectclass.Text)
                    .Average(x => x.Osztályzat)
                    .Select(x => new { Név = x.Név, Osztály = x.Osztály, Évfolyam = x.Évfolyam, Osztályzat = x.Osztályzat })
                    .ToList();
                grades.ItemsSource = averagevar;
            }
            else if (selectclass.Text == "11A")
            {
                grades.Items.Refresh();
                var averagevar = jegyek
                    .Where(x => x.Osztály == selectclass.Text)
                    .Average(x => x.Osztályzat)
                    .Select(x => new { Név = x.Név, Osztály = x.Osztály, Évfolyam = x.Évfolyam, Osztályzat = x.Osztályzat })
                    .ToList();
                grades.ItemsSource = averagevar;
            }
            else if (selectclass.Text == "11B")
            {
                grades.Items.Refresh();
                var averagevar = jegyek
                    .Where(x => x.Osztály == selectclass.Text)
                    .Average(x => x.Osztályzat)
                    .Select(x => new { Név = x.Név, Osztály = x.Osztály, Évfolyam = x.Évfolyam, Osztályzat = x.Osztályzat })
                    .ToList();
                grades.ItemsSource = averagevar;
            }
            else if (selectclass.Text == "11C")
            {
                grades.Items.Refresh();
                var averagevar = jegyek
                    .Where(x => x.Osztály == selectclass.Text)
                    .Average(x => x.Osztályzat)
                    .Select(x => new { Név = x.Név, Osztály = x.Osztály, Évfolyam = x.Évfolyam, Osztályzat = x.Osztályzat })
                    .ToList();
                grades.ItemsSource = averagevar;
            }
            else if (selectclass.Text == "12A")
            {
                grades.Items.Refresh();
                var averagevar = jegyek
                    .Where(x => x.Osztály == selectclass.Text)
                    .Average(x => x.Osztályzat)
                    .Select(x => new { Név = x.Név, Osztály = x.Osztály, Évfolyam = x.Évfolyam, Osztályzat = x.Osztályzat })
                    .ToList();
                grades.ItemsSource = averagevar;
            }
            else if (selectclass.Text == "12B")
            {
                grades.Items.Refresh();
                var averagevar = jegyek
                    .Where(x => x.Osztály == selectclass.Text)
                    .Average(x => x.Osztályzat)
                    .Select(x => new { Név = x.Név, Osztály = x.Osztály, Évfolyam = x.Évfolyam, Osztályzat = x.Osztályzat })
                    .ToList();
                grades.ItemsSource = averagevar;
            }
            else if (selectclass.Text == "12C")
            {
                grades.Items.Refresh();
                var averagevar = jegyek
                    .Where(x => x.Osztály == selectclass.Text)
                    .Average(x => x.Osztályzat)
                    .Select(x => new { Név = x.Név, Osztály = x.Osztály, Évfolyam = x.Évfolyam, Osztályzat = x.Osztályzat })
                    .ToList();
                grades.ItemsSource = averagevar;
            }

            */
        }
    }
}
