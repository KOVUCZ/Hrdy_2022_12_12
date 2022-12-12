using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Hrdy_2022_12_12
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public class Solider
    {
        public string název = "";
        public int hp { get; set; }

        public int maxhp { get; set; }

        public int damage { get; set; }

        public int shield { get; set; }

        public int maxshield { get; set; }

        public int level { get; set; }

        public Solider()
        {
            název = "ten první";
            hp = 0;
            maxhp = 100;
            damage = 0;
            shield = 100;
            maxshield = 100;
            level = 0;
        }

        public void Damage()
        {
            damage += 1;
            
        }

        public void HP()
        {
            hp += 10;
        }

        public void Level()
        {
            level += 1;
        }

        public void Heal()
        {
            damage -= 1;
            hp -= 1;
        }


    }
}
