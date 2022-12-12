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

namespace Hrdy_2022_12_12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        Solider TenPrvni;
        Solider TenDruhy;

        public MainWindow()
        {
            InitializeComponent();
            TenPrvni = new Solider();
            TenPrvni.název = "Ten První";
            Zobraz(TenPrvni, Text1);

            TenDruhy = new Solider();
            TenDruhy.název = "Ten Druhý";
            Zobraz(TenPrvni, Text2);
        }

        public void Zobraz(Solider solider, TextBox textBox)
        {
            textBox.Text = solider.název + "\n";
            textBox.Text += "HP: " + solider.hp.ToString() + "hp" + "\n";
            textBox.Text += "Max HP: " + solider.maxhp.ToString() + "maxhp" + "\n";
            textBox.Text += "Damage: " + solider.damage.ToString() + "damage" + "\n";
            textBox.Text += "Shield: " + solider.shield.ToString() + "shield" + "\n";
            textBox.Text += "Max Shiels: " + solider.maxshield.ToString() + "maxshield" + "\n";
            textBox.Text += "Level: " + solider.level.ToString() + "level" + "\n";
        }

        private void attack1_Click(object sender, RoutedEventArgs e)
        {
            TenDruhy.Damage();
            Zobraz(TenDruhy, Text2);
            
        }

        private void attack2_Click(object sender, RoutedEventArgs e)
        {
            TenPrvni.Damage();
            Zobraz(TenPrvni, Text1);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TenPrvni.HP();
            Zobraz(TenPrvni, Text1);

            TenPrvni.Level();
            Zobraz(TenPrvni, Text1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TenPrvni.Heal();
            Zobraz(TenPrvni, Text1);
        }

        private void heal2_Click(object sender, RoutedEventArgs e)
        {
            TenDruhy.Heal();
            Zobraz(TenDruhy, Text2);
        }

        private void lvlup2_Click(object sender, RoutedEventArgs e)
        {
            TenDruhy.Level();
            Zobraz(TenDruhy, Text2);

            TenDruhy.HP();
            Zobraz(TenDruhy, Text2);
        }
    }
   
}
