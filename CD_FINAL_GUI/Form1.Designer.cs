namespace CD_FINAL_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grammar1 = new System.Windows.Forms.RadioButton();
            this.grammar2 = new System.Windows.Forms.RadioButton();
            this.grammar3 = new System.Windows.Forms.RadioButton();
            this.title = new System.Windows.Forms.Label();
            this.choose_grammar_label = new System.Windows.Forms.Label();
            this.grammar_info = new System.Windows.Forms.Label();
            this.print_parse_table_btn = new System.Windows.Forms.Button();
            this.print_items_btn = new System.Windows.Forms.Button();
            this.input_string = new System.Windows.Forms.TextBox();
            this.parse_input_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grammar1
            // 
            this.grammar1.AutoSize = true;
            this.grammar1.Checked = true;
            this.grammar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grammar1.ForeColor = System.Drawing.Color.Olive;
            this.grammar1.Location = new System.Drawing.Point(433, 81);
            this.grammar1.Name = "grammar1";
            this.grammar1.Size = new System.Drawing.Size(112, 24);
            this.grammar1.TabIndex = 0;
            this.grammar1.TabStop = true;
            this.grammar1.Text = "Grammar 1";
            this.grammar1.UseVisualStyleBackColor = true;
            this.grammar1.CheckedChanged += new System.EventHandler(this.grammar1_CheckedChanged);
            // 
            // grammar2
            // 
            this.grammar2.AutoSize = true;
            this.grammar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grammar2.ForeColor = System.Drawing.Color.Olive;
            this.grammar2.Location = new System.Drawing.Point(596, 81);
            this.grammar2.Name = "grammar2";
            this.grammar2.Size = new System.Drawing.Size(112, 24);
            this.grammar2.TabIndex = 1;
            this.grammar2.Text = "Grammar 2";
            this.grammar2.UseVisualStyleBackColor = true;
            this.grammar2.CheckedChanged += new System.EventHandler(this.grammar2_CheckedChanged);
            // 
            // grammar3
            // 
            this.grammar3.AutoSize = true;
            this.grammar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grammar3.ForeColor = System.Drawing.Color.Olive;
            this.grammar3.Location = new System.Drawing.Point(740, 81);
            this.grammar3.Name = "grammar3";
            this.grammar3.Size = new System.Drawing.Size(112, 24);
            this.grammar3.TabIndex = 2;
            this.grammar3.Text = "Grammar 3";
            this.grammar3.UseVisualStyleBackColor = true;
            this.grammar3.CheckedChanged += new System.EventHandler(this.grammar3_CheckedChanged);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.title.Location = new System.Drawing.Point(359, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(254, 39);
            this.title.TabIndex = 3;
            this.title.Text = "LALR PARSER";
            // 
            // choose_grammar_label
            // 
            this.choose_grammar_label.AutoSize = true;
            this.choose_grammar_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose_grammar_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.choose_grammar_label.Location = new System.Drawing.Point(22, 81);
            this.choose_grammar_label.Name = "choose_grammar_label";
            this.choose_grammar_label.Size = new System.Drawing.Size(195, 25);
            this.choose_grammar_label.TabIndex = 4;
            this.choose_grammar_label.Text = "Choose a grammar : ";
            // 
            // grammar_info
            // 
            this.grammar_info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grammar_info.Font = new System.Drawing.Font("Cooper Black", 17.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grammar_info.ForeColor = System.Drawing.Color.SandyBrown;
            this.grammar_info.Location = new System.Drawing.Point(47, 161);
            this.grammar_info.Name = "grammar_info";
            this.grammar_info.Size = new System.Drawing.Size(451, 358);
            this.grammar_info.TabIndex = 5;
            this.grammar_info.Text = "asas";
            // 
            // print_parse_table_btn
            // 
            this.print_parse_table_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_parse_table_btn.Location = new System.Drawing.Point(538, 161);
            this.print_parse_table_btn.Name = "print_parse_table_btn";
            this.print_parse_table_btn.Size = new System.Drawing.Size(375, 44);
            this.print_parse_table_btn.TabIndex = 6;
            this.print_parse_table_btn.Text = "Print Parse Table";
            this.print_parse_table_btn.UseVisualStyleBackColor = true;
            this.print_parse_table_btn.Click += new System.EventHandler(this.print_parse_table_btn_Click);
            // 
            // print_items_btn
            // 
            this.print_items_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_items_btn.Location = new System.Drawing.Point(538, 253);
            this.print_items_btn.Name = "print_items_btn";
            this.print_items_btn.Size = new System.Drawing.Size(375, 42);
            this.print_items_btn.TabIndex = 7;
            this.print_items_btn.Text = "Print Items";
            this.print_items_btn.UseVisualStyleBackColor = true;
            this.print_items_btn.Click += new System.EventHandler(this.print_items_btn_Click);
            // 
            // input_string
            // 
            this.input_string.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_string.Location = new System.Drawing.Point(538, 362);
            this.input_string.Name = "input_string";
            this.input_string.Size = new System.Drawing.Size(113, 30);
            this.input_string.TabIndex = 8;
            // 
            // parse_input_btn
            // 
            this.parse_input_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parse_input_btn.Location = new System.Drawing.Point(689, 359);
            this.parse_input_btn.Name = "parse_input_btn";
            this.parse_input_btn.Size = new System.Drawing.Size(206, 33);
            this.parse_input_btn.TabIndex = 9;
            this.parse_input_btn.Text = "Parse Input";
            this.parse_input_btn.UseVisualStyleBackColor = true;
            this.parse_input_btn.Click += new System.EventHandler(this.parse_input_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 602);
            this.Controls.Add(this.parse_input_btn);
            this.Controls.Add(this.input_string);
            this.Controls.Add(this.print_items_btn);
            this.Controls.Add(this.print_parse_table_btn);
            this.Controls.Add(this.grammar_info);
            this.Controls.Add(this.choose_grammar_label);
            this.Controls.Add(this.title);
            this.Controls.Add(this.grammar3);
            this.Controls.Add(this.grammar2);
            this.Controls.Add(this.grammar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton grammar1;
        private System.Windows.Forms.RadioButton grammar2;
        private System.Windows.Forms.RadioButton grammar3;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label choose_grammar_label;
        private System.Windows.Forms.Label grammar_info;
        private System.Windows.Forms.Button print_parse_table_btn;
        private System.Windows.Forms.Button print_items_btn;
        private System.Windows.Forms.TextBox input_string;
        private System.Windows.Forms.Button parse_input_btn;
    }
}

