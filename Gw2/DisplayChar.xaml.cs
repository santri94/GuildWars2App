using System;
using System.Collections.Generic;
using System.IO;
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

namespace Gw2
{
    /// <summary>
    /// Interaction logic for DisplayChar.xaml
    /// </summary>
    public partial class DisplayChar : Window
    {
        Character selected = new Character();
        public DisplayChar(Character selected)
        {
            InitializeComponent();
            this.selected = selected;
            DisplayInfo();
        }

        public void DisplayInfo()
        {
            Name.Text = selected.name;
            RaceProfession.Text = $"{selected.race} - {selected.profession}";
            CharImage.Source = new BitmapImage(new Uri(GetImage()));

            Backpack.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\Images\\Items\\Backpack.png"));
            Helm.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\Images\\Items\\Helm.png"));
            Boots.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\Images\\Items\\Boots.png"));
            Gloves.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\Images\\Items\\Gloves.png"));
            Ring1.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\Images\\Items\\Ring.png"));
            Ring2.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\Images\\Items\\Ring.png"));
            Amulet.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\Images\\Items\\Amulet.png"));
            WeaponA1.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\Images\\Items\\Weapon.png"));
            WeaponA2.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\Images\\Items\\Weapon.png"));

        }

        public string GetImage()
        {
            string image = "";
            if (selected.race == "Asura")
            {
                image = Directory.GetCurrentDirectory() + "\\Images\\Asura.jpg";
            }
            if (selected.race == "Charr")
            {
                image = Directory.GetCurrentDirectory() + "\\Images\\Charr.jpg";
            }
            if (selected.race == "Human")
            {
                image = Directory.GetCurrentDirectory() + "\\Images\\Human.jpg";
            }
            if (selected.race == "Norn")
            {
                image = Directory.GetCurrentDirectory() + "\\Images\\Norn.jpg";
            }
            if (selected.race == "Sylvari")
            {
                image = Directory.GetCurrentDirectory() + "\\Images\\Sylvari.jpg";
            }
            return image;
        }
    }
}
