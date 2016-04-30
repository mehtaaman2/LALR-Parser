using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeProject.Syntax.LALR;
namespace CD_FINAL_GUI
{
    
    public partial class Form3 : Form
    {
        Grammar grammar;
        public Form3(Grammar g)
        {
            InitializeComponent();
            grammar = g;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Parser parser = new Parser(grammar);
            int nStates = parser.ParseTable.Actions.GetLength(0) + 1;
            Label[] labels = new Label[nStates];
            Size size = this.Size;
            int x = size.Width / 5;
            int y;
            for (int i=0;i<nStates-1;i++)
            {
                labels[i] = new Label();
                labels[i].Text = Debug.DumpLALRStates(parser, i);
                labels[i].Name = "State " + i;
                labels[i].Width = 200;
                labels[i].Height = 300;
                y = i / 5;
                labels[i].Location = new Point(x*(i%5)+10, y * (labels[i].Height) +y*40+20);
                labels[i].Font = new Font(labels[i].Font.FontFamily, 15);
                labels[i].BorderStyle = BorderStyle.FixedSingle;
                this.Controls.Add(labels[i]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
