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

namespace Gw2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpConnection.SetUp();
            test();
        }

        public async void test()
        {
            await LoadCharacters.GetAllCharactersAsync();
            foreach (var item in LoadCharacters.charactersList)
            {
                CharactersComboBox.Items.Add(item.name);
            }
            Loading.Visibility = Visibility.Hidden;
            CharactersComboBox.Visibility = Visibility.Visible;
            ShowCharacter.Visibility = Visibility.Visible;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (CharactersComboBox.Text == "")
            {
                // dont do anything
            }
            else
            {
                Character selected = new Character();
                selected = LoadCharacters.charactersList.Where(x => x.name == CharactersComboBox.Text).ToList()[0];
                DisplayChar displayCharacter = new DisplayChar(selected);
                displayCharacter.Show();
                this.Close();
            }
        }
    }
}
