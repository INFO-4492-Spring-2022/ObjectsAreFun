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

namespace ObjectsAreFun {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private List<Person> _Peoples = new List<Person>();

        public MainWindow() {
            InitializeComponent();


            //Person per;
            //per = new Person();
            // setter
            //per.FirstName = "Fred";
            // getter
            //MessageBox.Show(p.FirstName);

            Citizen cit = new Citizen();
            cit.FirstName = "Fred";

            Superhero sup = new Superhero();
            sup.FirstName = "Venom";


            _Peoples.Add(sup);
            _Peoples.Add(new Superhero() { FirstName = "Wonder", LastName = "Woman" });
            _Peoples.Add(new Superhero() { FirstName = "Bat", LastName = "Man" });
            _Peoples.Add(new Superhero() { FirstName = "The", LastName = "Flash" });
            _Peoples.Add(cit);

            //MessageBox.Show(sup.Shout());


            Villian vil = new Villian();
            vil.FirstName = "Harvey";
            vil.LastName = "Oswald";

            _Peoples.Add(vil);

            sup.Identity = "Dudel";
            vil.Minion = "thing";
            cit.LastName = "Flintstone";
        }

        private void btnShowPeople_Click(object sender, RoutedEventArgs e) {
            tbOutput.Text = "";
            foreach (Person peop in _Peoples) {
                tbOutput.Text += peop.FirstName + " is a " + peop + " and says " 
                    + peop.Shout() +"\n";
            }

        }
    }
}
