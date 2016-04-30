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
    public partial class Form4 : Form
    {
        Grammar grammar;
        String str;
        static string print(Stack<int> t)
        {
            Stack<int> temp2;
            temp2 = new Stack<int>(t);
            string stack_str = "";
            for (int i = 0; i <= temp2.Count; i++)
                stack_str += temp2.Pop().ToString();
            char[] charArray = stack_str.ToCharArray();
            //Array.Reverse(charArray);
            stack_str = new string(charArray);
            Console.Write(stack_str);
            return stack_str;
        }
        static string print(Stack<string> t)
        {
            Stack<string> temp2;
            temp2 = new Stack<string>(t);
            string stack_str = "";
            for (int i = 0; i <= temp2.Count; i++)
                stack_str += temp2.Pop().ToString();
            char[] charArray = stack_str.ToCharArray();
            //Array.Reverse(charArray);
            stack_str = new string(charArray);
            Console.Write(stack_str);
            return stack_str;
        }


        public static int getIndex(string[] token, string s, int inp)
        {
            if (s[inp] == '$')
            {
                //Console.WriteLine(1);
                return 1;

            }
            for (int i = 0; i < token.Length; i++)
            {
                if (token[i] == s[inp].ToString())
                {
                    //Console.WriteLine(i + 2);
                    return (i + 2);
                }

            }
            return -1;
        }
        static int[] parseString(string[,] parseTable, Grammar grammar, string str, string[,] parseInputTable)
        {
            int[] ret = new int[2];
            //parseInputTable= new string[30,4];
            Stack<int> stack = new System.Collections.Generic.Stack<int>();
            Stack<string> symbol = new System.Collections.Generic.Stack<string>();
            int inp_pointer = 0;
            Console.WriteLine();
            stack.Push(0);
            Production[] x = grammar.PrecedenceGroups[0].Productions;
            string[] token = grammar.Tokens;
            Console.WriteLine("Stack\tSymbol\tInput\tAction");
            parseInputTable[0, 0] = "Stack";
            parseInputTable[0, 1] = "Symbol";
            parseInputTable[0, 2] = "Input";
            parseInputTable[0, 3] = "Action";
            int l = 0;
            while (true)
            {
                // Console.WriteLine(++l);
                //input parsing
                l++;
                if (stack.Count != 0)
                {
                    string temp;
                    temp = print(stack);
                    if (stack.Count > 2)
                    {
                        temp += stack.Peek();
                        Console.Write(stack.Peek());
                    }
                    parseInputTable[l, 0] = temp;
                }
                else
                    Console.Write("");
                Console.Write("\t");
                if (symbol.Count != 0)
                {
                    string temp;
                    temp = print(symbol);
                    if (symbol.Count > 2)
                    {
                        Console.Write(symbol.Peek());
                        temp += symbol.Peek();
                    }
                    parseInputTable[l, 1] = temp;
                }
                else
                    Console.Write("");
                Console.Write("\t");
                Console.Write(str.Substring(inp_pointer, str.Length - inp_pointer));
                parseInputTable[l, 2] = str.Substring(inp_pointer, str.Length - inp_pointer);

                string value = parseTable[stack.Peek() + 1, getIndex(token, str, inp_pointer)];
                if (stack.Peek() == 0 && symbol.Count != 0 && symbol.Peek() == "S" && str[inp_pointer] == '$')
                {
                    Console.WriteLine("\n Input parsed!!");
                    ret[0] = 1;
                    ret[1] = l;
                    return ret;
                    //break;
                }

                else if (value.Contains("S"))
                {

                    int state = Int32.Parse(value[2].ToString());
                    stack.Push(state);

                    symbol.Push(str[inp_pointer].ToString());
                    inp_pointer++;
                    Console.WriteLine("\tShift " + state);
                    parseInputTable[l, 3] = "\tShift " + state;

                }
                else if (value.Contains("R"))
                {
                    int prod_no = Int32.Parse(value[2].ToString());
                    for (int i = 0; i < x[prod_no].Right.Length; i++)
                    {
                        symbol.Pop();
                        stack.Pop();
                    }
                    int token_inserted = x[prod_no].Left;
                    symbol.Push(token[token_inserted]);
                    //Console.WriteLine(stack.Peek() + "\t" + symbol.Peek() + "\t" + str.Substring(inp_pointer, str.Length - inp_pointer));

                    if (stack.Peek() == 0 && symbol.Count != 0 && symbol.Peek() == "S" && str[inp_pointer] == '$')
                    {
                        Console.WriteLine("\n Input parsed!!");
                        ret[0] = 1;
                        ret[1] = l;
                        return ret;
                        // break;
                    }
                    string temp = parseTable[stack.Peek() + 1, token_inserted + 2];
                    int state_inserted = Int32.Parse(temp[2].ToString());
                    stack.Push(state_inserted);
                    Console.WriteLine("\tReduce " + prod_no);
                    parseInputTable[l, 3] = "\tReduce " + prod_no;

                }
                else
                {
                    Console.WriteLine("\nParse error!");
                    ret[0] = -1;
                    ret[1] = l;
                    return ret;
                    //break;
                }

            }
        }
        public Form4(Grammar g,String s)
        {
            InitializeComponent();
            grammar = g;
            str = s;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Parser parser = new Parser(grammar);
            int nStates = parser.ParseTable.Actions.GetLength(0) + 1;
            int nTokens = parser.ParseTable.Actions.GetLength(1) + 1;
            // write the parse table to the screen
            string[,] parseTable = new string[nStates, nTokens];
            parseTable = Debug.DumpParseTable(parser);
            int[] status;
            string[,] parseInputTable = new string[100, 4];
            status = parseString(parseTable, grammar, str, parseInputTable);
            TableLayoutPanel dynamicTableLayoutPanel = new TableLayoutPanel();

            dynamicTableLayoutPanel.Location = new System.Drawing.Point(25, 50);
            dynamicTableLayoutPanel.Name = "TableLayoutPanel1";
            dynamicTableLayoutPanel.Size = new System.Drawing.Size(175*4 , (int)((status[1] + 0.5) * 35));
            dynamicTableLayoutPanel.BackColor = Color.LightBlue;
            // Add rows and columns
            dynamicTableLayoutPanel.ColumnCount = nTokens;
            dynamicTableLayoutPanel.RowCount = nStates;
            for (int k = 0; k < 4; k++)
                dynamicTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 175));
            for (int k = 0; k < status[1]; k++)
                dynamicTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35));
            dynamicTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            dynamicTableLayoutPanel.AutoScroll = true;
            for (int i = 0; i < status[1]; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Label label = new Label();
                    label.Text = parseInputTable[i, j];
                    label.Font = new Font(label.Font.FontFamily, 15);
                    if (i == 0)
                        label.ForeColor = Color.DarkViolet;
                    dynamicTableLayoutPanel.Controls.Add(label, j, i);

                }
            }

            // Add child controls to TableLayoutPanel and specify rows and column
            Controls.Add(dynamicTableLayoutPanel);
            //sets parse output status
            if(status[0]==-1)
            {
                parse_output.Text = "Parse Error!";
                parse_output.ForeColor = Color.Red;
            }
            else if (status[0] == -1)
            {
                parse_output.Text = "Input Parsed!";
                parse_output.ForeColor = Color.Green;
            }
        }
    }
}
