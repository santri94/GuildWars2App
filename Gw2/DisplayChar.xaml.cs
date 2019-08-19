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
        Character selected = new Character();
        public DisplayChar(Character selected)
        {
            InitializeComponent();
            this.selected = selected;
            test();
        }

        public void test()
        {
            Name.Text = selected.name;
        }
    }
}
