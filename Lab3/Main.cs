using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Lab3.Model;
using System.IO;

namespace Lab3
{
    public partial class Main : Form
    {
        public Main(int hp1,int hp2,int hp3)
        {
            InitializeComponent();
            roleContainer1.RedSize = hp1;
            roleContainer2.RedSize = hp2;
            roleContainer3.RedSize = hp3;
        }

        private void Main_load(object sender, EventArgs e)  //游戏战斗界面加载
        {
            roleContainer1.loadPic("D://WorkSpace//C_sharp//Lab3//data//saber.png");
            roleContainer2.loadPic("D://WorkSpace//C_sharp//Lab3//data//lanceralter.png");
            roleContainer3.loadPic("D://WorkSpace//C_sharp//Lab3//data//caster.png");
        }

        Warrior saber = new Warrior()
        {
            name = "saber",
            oldX = 59,
            oldY = 69,
            hp = 122,
            StrengthPoint = 32,
            IntellgencePoint = 1,
            weapon = new Weapon() { attackPoint = 10, defensePoint = 10, lucky = 10 }
        };

        Caster caster = new Caster()
        {
            name = "caster",
            oldX = 59,
            oldY = 301,
            hp = 122,
            StrengthPoint = 32,
            IntellgencePoint = 1,
            weapon = new Weapon() { attackPoint = 5, defensePoint = 5, lucky = 5 }
        };


        Monster alter = new Monster()
        {
            name = "alter",
            oldX = 629,
            oldY = 69,
            hp = 122,
            attackPoint = 40, //30
            defensePoint = 1
        };

        private void roleContainer1_Click(object sender, EventArgs e)
        {

            if (roleContainer2.RedSize <= 0)
            {
                MessageBox.Show("Hero win!");
            }
            else
            {
                saber.move(alter);
                roleContainer1.Location = new Point(saber.newX, saber.newY);
                roleContainer2.RedSize = alter.hp;
                roleContainer2.labelRed.Refresh();
                saber.back();
                Thread.Sleep(1000);
                roleContainer1.Location = new Point(saber.newX, saber.newY);
            }
        }
        private void roleContainer2_Click(object sender,EventArgs e)
        {
            if (roleContainer1.RedSize <= 0 || roleContainer3.RedSize<=0)
            {
                MessageBox.Show("Monster win!");
            }
            else
            {
                alter.move(saber);
                roleContainer2.Location = new Point(alter.newX, alter.newY);
                roleContainer1.RedSize = saber.hp;
                roleContainer1.Refresh();
                alter.back();
                Thread.Sleep(1000);
                roleContainer2.Location = new Point(alter.newX, alter.newY);
                
                Thread.Sleep(1000);

                alter.move(caster);
                roleContainer2.Location = new Point(alter.newX, alter.newY);
                roleContainer3.RedSize = caster.hp;
                roleContainer3.Refresh();
                alter.back();
                Thread.Sleep(1000);
                roleContainer2.Location = new Point(alter.newX, alter.newY);
            }
        }

        private void roleContainer3_Click(object sender, EventArgs e)
        {
            if (roleContainer2.RedSize <= 0)
            {
                MessageBox.Show("Hero win!");
            }
            else
            {
                caster.move(alter);
                roleContainer3.Location = new Point(caster.newX, caster.newY);
                roleContainer2.RedSize = alter.hp;
                caster.back();
                Thread.Sleep(1000);
                roleContainer3.Location = new Point(caster.newX, caster.newY);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();  
            sfd.Filter = "txt文本（*.txt）|*.txt";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                sw.Write("" + roleContainer1.RedSize + "\n");
                sw.Write("" + roleContainer2.RedSize + "\n");
                sw.Write("" + roleContainer3.RedSize + "\n");
                sw.Close();
                fs.Close();
                MessageBox.Show("保存成功");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Start start = new Start(roleContainer1.RedSize, roleContainer2.RedSize, roleContainer3.RedSize);
            this.Hide();
            start.ShowDialog(this);
            this.Close();
        }
    }
}
