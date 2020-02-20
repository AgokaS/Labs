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

namespace Karay1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<StudList> grupList = new List<StudList>
            {
                new StudList { Name= "Женя", SrName="Быков", ThrName="Игоревич", Numba="pin-118-01",Data="08.04.2001"},
                new StudList { Name= "Женя", SrName="Быков", ThrName="Игоревич", Numba="pin-118-01",Data="08.04.2001"},
                new StudList { Name= "Женя", SrName="Быков", ThrName="Игоревич", Numba="pin-118-01",Data="08.04.2001"},
                new StudList { Name= "Женя", SrName="Быков", ThrName="Игоревич", Numba="pin-118-01",Data="08.04.2001"},
                new StudList { Name= "Женя", SrName="Быков", ThrName="Игоревич", Numba="pin-118-01",Data="08.04.2001"},
                new StudList { Name= "Женя", SrName="Быков", ThrName="Игоревич", Numba="pin-118-01",Data="08.04.2001"},
                new StudList { Name= "Женя", SrName="Быков", ThrName="Игоревич", Numba="pin-118-01",Data="08.04.2001"},
                new StudList { Name= "Женя", SrName="Быков", ThrName="Игоревич", Numba="pin-118-01",Data="08.04.2001"},
                new StudList { Name= "Женя", SrName="Быков", ThrName="Игоревич", Numba="pin-118-01",Data="08.04.2001"},
                new StudList { Name= "Женя", SrName="Быков", ThrName="Игоревич", Numba="pin-118-01",Data="08.04.2001"},
                new StudList { Name= "Женя", SrName="Быков", ThrName="Игоревич", Numba="pin-118-01",Data="08.04.2001"},
                new StudList { Name= "Женя", SrName="Быков", ThrName="Игоревич", Numba="pin-118-01",Data="08.04.2001"}
            };
            StudGrid.ItemsSource = grupList;
        }

        private void Buton_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
