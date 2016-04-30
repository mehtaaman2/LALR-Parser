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
    public partial class Form2 : Form
    {
        Grammar grammar;
        public Form2(Grammar g)
        {
            InitializeComponent();
            grammar = g;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Parser parser = new Parser(grammar);
            int nStates = parser.ParseTable.Actions.GetLength(0) + 1;
            int nTokens = parser.ParseTable.Actions.GetLength(1) + 1;
            // write the parse table to the screen
            string[,] parseTable = new string[nStates, nTokens];
            parseTable = Debug.DumpParseTable(parser);
            TableLayoutPanel dynamicTableLayoutPanel = new TableLayoutPanel();

            dynamicTableLayoutPanel.Location = new System.Drawing.Point(26, 12);
            dynamicTableLayoutPanel.Name = "TableLayoutPanel1";
            dynamicTableLayoutPanel.Size = new System.Drawing.Size(nTokens*100, (int)((nStates+0.5)*35));
            dynamicTableLayoutPanel.BackColor = Color.LightBlue;
            // Add rows and columns
            dynamicTableLayoutPanel.ColumnCount = nTokens;
            dynamicTableLayoutPanel.RowCount = nStates;
            for (int k = 0; k < nTokens; k++)
                dynamicTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
            for (int k = 0; k < nStates; k++)
                dynamicTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35));
            dynamicTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            for (int i = 0; i < nStates; i++)
            {
                //Console.WriteLine();
                for (int j = 0; j < nTokens; j++)
                {
                    Label label = new Label();
                    label.Text = parseTable[i, j];
                    label.Font = new Font(label.Font.FontFamily, 15);
                    if (i == 0)
                        label.ForeColor = Color.DarkViolet;
                    if (j == 0)
                        label.ForeColor = Color.LimeGreen;
                    dynamicTableLayoutPanel.Controls.Add(label, j, i);

                }
            }

            // Add child controls to TableLayoutPanel and specify rows and column
            Controls.Add(dynamicTableLayoutPanel);
        }
    }
}
