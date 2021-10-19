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

namespace Solid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<IWriteClub> clubMembers = new List<IWriteClub>();
            var paper = new Paper();
            var word = new Word();
            var excel = new Excel();
            clubMembers.Add(paper);
            paper.Scribble();
            clubMembers.Add(word);

            var club = new Club();
            club.AddNewMember(excel);

            foreach (var member in clubMembers)
            {
                member.Write();
            }

            var model = new GameViewModel(null, null);
            model.Human = new Human();
            model.AddPlayer(new Cpu());
        }
    }
}
