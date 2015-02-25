using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertToUnicode
{
    public partial class converter : Form
    {
        public converter()
        {
            InitializeComponent();
        }

        private void input_TextChanged(object sender, EventArgs e)
        {       
        }

        private void output_TextChanged(object sender, EventArgs e)
        {
        }

        private void convert_Click(object sender, EventArgs e)
        {
            output.Clear();
            output.Text = Converter.ToUnicode(input.Text);
        }

    }
}
