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
            LoadItemsPics();
        }

        private async void LoadItemsPics()
        {
            foreach (var item in selected.equipment)
            {
                //await LoadItemsImages.GetAllItemsImages(item.id);
                item.icon = await LoadItemsImages.GetAllItemsImages(item.id);
            }
            DisplayInfo();
            //HooverFunc();
        }

        private void Helm_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            //Team team = new Team();
            //team = teams.Teams.Where(x => x.idTeam == chooseTeam).ToList()[0];
            //var x = teams.Teams.Single(t => t.idTeam == chooseTeam);
            //Items selected = 

            //Getting Exactly the item that was clicked
            var x = selected.equipment.Single(t => t.slot == "Helm");

            Item helm = new Item(x);
            helm.Show();

        }


        public void DisplayInfo()
        {
            Name.Text = selected.name;
            RaceProfession.Text = $"{selected.race} - {selected.profession}";
            CharImage.Source = new BitmapImage(new Uri(GetImage()));
            //----------------------------------------------------------------------------------------------------------
            //                                          Getting Images or setting defaults
            //----------------------------------------------------------------------------------------------------------
            foreach (var item in selected.equipment)
            {
                if (item.slot == "Backpack")
                {

                    Backpack.Source = new BitmapImage(new Uri(item.icon));
                    Backpack.Opacity = 1.0;

                }
                if (item.slot == "Helm")
                {
                    Helm.Source = new BitmapImage(new Uri(item.icon));
                    Helm.Opacity = 1.0;

                }
                if (item.slot == "Boots")
                {
                    Boots.Source = new BitmapImage(new Uri(item.icon));
                    Boots.Opacity = 1.0;

                }
                if (item.slot == "Gloves")
                {
                    Gloves.Source = new BitmapImage(new Uri(item.icon));
                    Gloves.Opacity = 1.0;

                }
                if (item.slot == "Ring1")
                {
                    Ring1.Source = new BitmapImage(new Uri(item.icon));
                    Ring1.Opacity = 1.0;

                }
                if (item.slot == "Ring2")
                {
                    Ring2.Source = new BitmapImage(new Uri(item.icon));
                    Ring2.Opacity = 1.0;

                }
                if (item.slot == "Amulet")
                {
                    Amulet.Source = new BitmapImage(new Uri(item.icon));
                    Amulet.Opacity = 1.0;

                }
                if (item.slot == "WeaponA1")
                {
                    WeaponA1.Source = new BitmapImage(new Uri(item.icon));
                    WeaponA1.Opacity = 1.0;

                }
                if (item.slot == "WeaponA2")
                {
                    WeaponA2.Source = new BitmapImage(new Uri(item.icon));
                    WeaponA2.Opacity = 1.0;

                }





            }
            //----------------------------------------------------------------------------------------------------------
            if (Backpack.Source == null)
            {
                Backpack.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\Images\\Items\\Backpack.png"));

            }
            if (Helm.Source == null)
            {
                Helm.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\Images\\Items\\Helm.png"));

            }
            if (Boots.Source == null)
            {
                Boots.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\Images\\Items\\Boots.png"));
            }
            if (Gloves.Source == null)
            {
                Gloves.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\Images\\Items\\Gloves.png"));

            }
            if (Ring1.Source == null)
            {
                Ring1.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\Images\\Items\\Ring.png"));

            }
            if (Ring2.Source == null)
            {
                Ring2.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\Images\\Items\\Ring.png"));

            }
            if (Amulet.Source == null)
            {
                Amulet.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\Images\\Items\\Amulet.png"));

            }
            if (WeaponA1.Source == null)
            {
                WeaponA1.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\Images\\Items\\Weapon.png"));

            }
            if (WeaponA2.Source == null)
            {
                WeaponA2.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "\\Images\\Items\\Weapon.png"));

            }

            Helm.MouseLeftButtonDown += Helm_MouseLeftButtonDown;


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
