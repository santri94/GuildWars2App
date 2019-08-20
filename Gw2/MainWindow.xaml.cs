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
            SetLogo();
            SetUpConnection.SetUp();
        }

        private void SetLogo()
        {
            var path = Directory.GetCurrentDirectory()+ "\\Images\\Logo.jpg";
            Logo.Source = new BitmapImage(new Uri(path));
            Logo.Visibility = Visibility.Hidden;
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

        private async void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            if (Token.Text == "")
            {
                InvalidToken.Visibility = Visibility.Hidden;
                EnterToken.Visibility = Visibility.Visible;
            }
            else if (Token.Text.Length < 60 && Token.Text != "")
            {
                // small security
                EnterToken.Visibility = Visibility.Hidden;
                InvalidToken.Visibility = Visibility.Visible;
            }
            else
            {
                TokenText.Visibility = Visibility.Hidden;
                Token.Visibility = Visibility.Hidden;
                EnterButton.Visibility = Visibility.Hidden;
                EnterToken.Visibility = Visibility.Hidden;
                InvalidToken.Visibility = Visibility.Hidden;
                Loading.Visibility = Visibility.Visible;
                Logo.Visibility = Visibility.Visible;
                await LoadCharacters.GetAllCharactersAsync(Token.Text);
                foreach (var item in LoadCharacters.charactersList)
                {
                    CharactersComboBox.Items.Add(item.name);
                }
                Loading.Visibility = Visibility.Hidden;
                CharactersComboBox.Visibility = Visibility.Visible;
                ShowCharacter.Visibility = Visibility.Visible;

            }
        }
    }
}
