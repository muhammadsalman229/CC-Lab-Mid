using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LL1_MID_Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            string input = InputRichTextBox.Text;
            Parser parser = new Parser(input);

            if (parser.ParseList())
            {
                ResultLabel.Text = "Valid input!";
            }
            else
            {
                ResultLabel.Text = "Invalid input!";
            }
        }
        public class Parser
        {
            private string[] tokens;
            private int index;

            public Parser(string input)
            {
                this.tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                this.index = 0;
            }

            public bool ParseList()
            {
                if (ParseItem())
                {
                    return ParseRest();
                }
                return false;
            }

            private bool ParseRest()
            {
                if (index < tokens.Length && tokens[index] == ",")
                {
                    index++;
                    if (ParseItem())
                    {
                        return ParseRest();
                    }
                    return false;
                }
                return true; // ε-production
            }

            private bool ParseItem()
            {
                if (index < tokens.Length)
                {
                    string token = tokens[index];
                    if (token == "id" || token == "num" || token == "string")
                    {
                        index++;
                        return true;
                    }
                }
                return false;
            }
        }
    }

}
