using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Lab3.Model;

namespace Lab3
{
    public partial class Start : Form
    {
        public int hp1;
        public int hp2;
        public int hp3;
        public Start(int h1,int h2,int h3)
        {
            InitializeComponent();
            hp1 = h1;
            hp2 = h2;
            hp3 = h3;
        }

        private void creatMain()
        {
            Main main = new Main(this.hp1, this.hp2, this.hp3);
            this.Hide();
            main.ShowDialog(this);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hp1 = 122; hp2 = 122; hp3 = 122;
            creatMain();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "txt 文件|*.txt";
            of.Title = "文本读取";
            if (of.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(of.FileName, Encoding.Default);
                this.hp1 = int.Parse(sr.ReadLine());
                this.hp2 = int.Parse(sr.ReadLine());
                this.hp3 = int.Parse(sr.ReadLine());
                sr.Close();
                creatMain();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            creatMain();
        }
    }
}
