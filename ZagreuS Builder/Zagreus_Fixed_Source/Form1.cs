using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

//
// Decompiled + Fixed by HeightCoder
//

namespace Zagreus_Fixed_Source
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new fRCWQdUOPAClUJZZPQmd();
            newForm.Show();
            this.Hide();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int num = Conversions.ToInteger(RmVved.Text);
            RmVved.Text = Conversions.ToString(checked(num - 1));
            if (Operators.CompareString(RmVved.Text, "0", TextCompare: false) == 0)
            {
                button1.Enabled = true;
                timer1.Stop();
                RmVved.Text = "";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectData.EndApp();
        }
    }
}
