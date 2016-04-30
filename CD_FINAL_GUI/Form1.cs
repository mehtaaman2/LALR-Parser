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

    //Functions used


    public partial class Form1 : Form
    {
        Grammar gram1, gram2, gram3,current_grammar;
        //functions used
        static string printGrammar(Grammar grammar)
        {
            string res = "";
            Production[] x = grammar.PrecedenceGroups[0].Productions;
            string[] token = grammar.Tokens;
            for (int i = 0; i < x.Length; i++)
            {
                res += token[x[i].Left] + " --> ";
                Console.Write(token[x[i].Left] + " --> ");
                for (int j = 0; j < x[i].Right.Length; j++)
                {
                    res += token[x[i].Right[j]] + " ";
                    Console.Write(token[x[i].Right[j]] + " ");
                }
                res += "\n";
                Console.WriteLine();

            }
            Parser parser = new Parser(grammar);
            res += "\n\n";
            res+=Debug.DumpTerminals(parser);
            res += "\n";
            res += Debug.DumpNonterminals(parser);
            return res;
        }

        public void InitializeGrammars()
        {
            //Grammar 1
            // S -> C C
            // C -> c C
            // C -> d

            //
            //
            gram1 = new Grammar();
            gram1.Tokens = new string[] { "S", "C", "c", "d" };

            gram1.PrecedenceGroups = new PrecedenceGroup[]
            {
                new PrecedenceGroup
                {
                    Derivation = Derivation.None,
                    Productions = new Production[]
                    {
						//S -> C C
						new Production{
                            Left = 0,
                            Right = new int[]{1 , 1}
                        },
						//C -> c C
						new Production{
                            Left = 1,
                            Right = new int[]{2 , 1}
                        },
						//C -> d
						new Production{
                            Left = 1,
                            Right =  new int[]{3}
                        }
                    }
                }
            };


            //Grammar 2
            // S -> a A b A
            // A -> a A b c
            // A -> a

            //
            //
            gram2 = new Grammar();
            gram2.Tokens = new string[] { "S", "a", "A", "b" , "c" };

            gram2.PrecedenceGroups = new PrecedenceGroup[]
            {
                new PrecedenceGroup
                {
                    Derivation = Derivation.None,
                    Productions = new Production[]
                    {
						//S -> a A b A
						new Production{
                            Left = 0,
                            Right = new int[]{1 , 2 , 3 ,1 }
                        },
						//A -> a A b c
						new Production{
                            Left = 2,
                            Right = new int[]{1 , 2 , 3, 4}
                        },
						//A -> a
						new Production{
                            Left = 2,
                            Right =  new int[]{1}
                        }
                    }
                }
            };


            //Grammar 3
            // S -> N
            // N -> V = E
            // N -> E
            // E -> V
            // V -> x
            // V -> * E
            //
            gram3 = new Grammar();
            gram3.Tokens = new string[] { "S", "N", "V", "=", "E","x","*" };

            gram3.PrecedenceGroups = new PrecedenceGroup[]
            {
                new PrecedenceGroup
                {
                    Derivation = Derivation.None,
                    Productions = new Production[]
                    {
						//S -> N
						new Production{
                            Left = 0,
                            Right = new int[]{1 }
                        },
						//N -> V = E
						new Production{
                            Left = 1,
                            Right = new int[]{2,3,4 }
                        },
						//N -> E
						new Production{
                            Left = 1,
                            Right =  new int[]{4}
                        },
                        //E -> V
						new Production{
                            Left = 4,
                            Right =  new int[]{2}
                        },
                        //V -> x
						new Production{
                            Left = 2,
                            Right =  new int[]{5}
                        },
                          //V -> * E
						new Production{
                            Left = 2,
                            Right =  new int[]{6,4}
                        }
                    }
                }
            };



        }

        private void print_parse_table_btn_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(current_grammar);
            form.Show();
        }

        private void parse_input_btn_Click(object sender, EventArgs e)
        {
            if(input_string.Text=="")
                MessageBox.Show("Enter some input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                String input = input_string.Text + "$";
                Form4 form = new Form4(current_grammar, input);
                form.Show();
            }
            
            
        }

        private void grammar2_CheckedChanged(object sender, EventArgs e)
        {
            current_grammar = gram2;
            grammar_info.Text = printGrammar(current_grammar);
        }

        private void grammar3_CheckedChanged(object sender, EventArgs e)
        {
            current_grammar = gram3;
            grammar_info.Text = printGrammar(current_grammar);
        }

        private void print_items_btn_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(current_grammar);
            form.Show();
        }

        public Form1()
        {
            InitializeComponent();
            InitializeGrammars();
            current_grammar = gram1;
            grammar_info.Text = printGrammar(current_grammar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void grammar1_CheckedChanged(object sender, EventArgs e)
        {
            current_grammar = gram1;
            grammar_info.Text = printGrammar(current_grammar);
        }
    }
}
