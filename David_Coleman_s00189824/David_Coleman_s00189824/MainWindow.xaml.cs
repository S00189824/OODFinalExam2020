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
using David_Coleman_s00189824;

namespace David_Coleman_s00189824
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PhoneData db = new PhoneData();
        string URL = "../..";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from p in db.Phones
                        select p;

            

            Lbxphones.ItemsSource = query.ToList();
        }

        private void Lbxphones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Phone selectedItem = Lbxphones.SelectedItem as Phone;

            if(selectedItem != null)
            {
                TblkPrice.Text =  "€" + selectedItem.Price.ToString();
                ImgPhone.Fill = new ImageBrush(new BitmapImage(new Uri(URL + selectedItem.Phone_Image, UriKind.Relative)));
            }
        }
    }
}
