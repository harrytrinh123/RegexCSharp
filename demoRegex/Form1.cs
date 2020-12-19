using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoRegex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void stringInput_KeyUp(object sender, KeyEventArgs e)
        {
            Regex reg = new Regex(regex.Text);
            bool result = reg.IsMatch(stringInput.Text);
            labelResult.Text = result.ToString();
        }
    }
}
