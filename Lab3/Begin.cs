using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Begin : Form
    {
        public Begin()
        {
            InitializeComponent();
        }
        private void startGame(object sender, EventArgs e)
        {
            Start start = new Start(122,122,122);
            this.Hide();
            start.ShowDialog(this);
            this.Close();
        }

        private void Begin_Load(object sender, EventArgs e)
        {

        }
    }
}
