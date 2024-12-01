using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishToolLevel2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt.Font = new Font("Arial", 24);
        }

        private void txt_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string[] day1 =
            {
            };

            string[] ConcatenateArrays(params string[][] arrays)
            {
                return arrays.SelectMany(a => a).ToArray();
            }

            string[] arrtxt = ConcatenateArrays(day1);

            Random randomTxt = new Random();
            txt.Text = arrtxt[randomTxt.Next(0, arrtxt.Length)];
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string[] day1 =
            {
            };

            string[] ConcatenateArrays(params string[][] arrays)
            {
                return arrays.SelectMany(a => a).ToArray();
            }

            string[] arrtxt = ConcatenateArrays(day1);

            Random randomTxt = new Random();
            txt.Text = arrtxt[randomTxt.Next(0, arrtxt.Length)];
        }
    }
}
