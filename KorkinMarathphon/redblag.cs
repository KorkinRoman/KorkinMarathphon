using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorkinMarathphon
{
    public partial class redblag : Form
    {
        public redblag()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            new uprblorg().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            new mainscreen().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new uprblorg().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            new uprblorg().Show();
        }
    }
}
