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

namespace BufeSzimulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Termek> termekek;
        private Vasarlo vasarlo;
        public MainWindow()
        {
            InitializeComponent();

            termekek = new List<Termek>();
            vasarlo = new Vasarlo(5000);

            AlapTermekekLetrehozasa();
            TermekListaFrissitese();
            VasarloAdatokFrissitese();
        }
        public void AlapTermekekLetrehozasa()
        {
            termekek.Add(new Etel("Szendvics", 1500, 500));
            termekek.Add(new Etel("Hot-dog", 1200, 600));
            termekek.Add(new Etel("Pizza szelet", 850, 500));
            termekek.Add(new Ital("Kávé", 700, 150));
            termekek.Add(new Ital("Kóla", 600, 500));
            termekek.Add(new Ital("Víz", 500, 500));
            
        }
        public void TermekListaFrissitese()
        {
            lbTermekek.Items.Clear();

            foreach (var termek in termekek)
            {
                lbTermekek.Items.Add(termek);
            }
        }
        public void VasarloAdatokFrissitese()
        {
            txtPenz.Text = $"Pénz: {vasarlo.Penz} Ft";
            txtElkoltott.Text = $"Elköltött pénz: {vasarlo.ElkoltottPenz} Ft";
            txtDarab.Text = $"Vásárlások száma: {vasarlo.Vasarlasok.Count} db";
        }
    }
}