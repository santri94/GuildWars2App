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
using System.Windows.Shapes;

namespace Gw2
{
    /// <summary>
    /// Interaction logic for DisplayChar.xaml
    /// </summary>
    public partial class DisplayChar : Window
    {
        public List<Character> charactersList = new List<Character>();
        public DisplayChar(List<Character> characters)
        {
            InitializeComponent();
            this.charactersList = characters; 
            test();
        }

        public void test()
        {
            //MessageBox.Show($"List has: {LoadCharacters.charactersList.Count}");
            Count.Text = "Chars: " + charactersList.Count.ToString();
        }
    }
}
