using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CommonTool
{
    public partial class Hex2String : Form
    {
        public Hex2String()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength <= 0) return;

            bool hex2String = false;
            if (richTextBox1.Text.Length > 0 && richTextBox1.Text.Length%3 == 0)
            {
                hex2String = true;
                for (int i = 0; i < richTextBox1.TextLength/3; i++)
                {
                    if (richTextBox1.Text[i*3 + 2] != ' ')
                    {
                        hex2String = false;
                        break;
                    }
                }
            }

            if (hex2String) //16进制转字符串
            {
                string inString = this.richTextBox1.Text;
                string[] splitsStrings = inString.Split(' ');
                byte[] convertBytes = new byte[splitsStrings.Length];

                int bytsInserted = 0;
                foreach (int value in from eachSplit in splitsStrings where !string.IsNullOrEmpty(eachSplit) select Convert.ToInt32(eachSplit, 16) into value where value > 0 select value)
                {
                    convertBytes[bytsInserted] = (byte)value;
                    bytsInserted += 1;
                }
                this.richTextBox2.Text = System.Text.Encoding.Default.GetString(convertBytes);
            }
        }
    }
}
