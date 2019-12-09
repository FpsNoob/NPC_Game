using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab3
{
    public partial class roleContainer :UserControl
    {
        public void loadPic(string url)  //加载图片
        {
            pictureBox1.Image = Image.FromFile(url);
        }

        public int RedSize
        {
            get { return labelRed.Width; }
            set { labelRed.Width = value; }
        }
        public roleContainer()
        {
            InitializeComponent();
        }

        private void picturebox_Click(object sender, EventArgs e)
        {
            base.OnClick(e);
        }
    }
}
