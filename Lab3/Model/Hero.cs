using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab3.Model
{
    abstract class Hero
    {
        public string name;
        public int oldX;
        public int oldY;
        public int newX;
        public int newY;
        public int hp;
        public Weapon weapon;

        private int strengthPoint;
        public int StrengthPoint
        {
            get { return strengthPoint; }
            set { strengthPoint = value; }
        }
        private int intellgencePoint;

        public int IntellgencePoint
        {
            get { return intellgencePoint; }
            set { intellgencePoint = value; }
        }

        private int attackPoint;
        public int AttackPoint
        {
            get { return attackPoint; }
            set { attackPoint = value; }
        }

        private int defensePoint;
        public int DefensePoint
        {
            get { return defensePoint; }
            set { defensePoint = value; }
        }

        virtual public void move(Monster monster)
        {
            this.newX = monster.oldX - 120;
            this.newY = monster.oldY;
            calAttackPoint();
            calDefensePoint();
            int offset = this.AttackPoint - monster.defensePoint;
            if (offset > 0)
            {
                MessageBox.Show("攻击力："+this.AttackPoint);
                MessageBox.Show("攻击者HP：" + this.hp);
                MessageBox.Show("Lucky：" + this.weapon.lucky);
                monster.hp = monster.hp - this.AttackPoint+monster.defensePoint;
            }
        }
        virtual public void back()
        {
            this.newX = this.oldX;
            this.newY = this.oldY;
        }
        public abstract void calAttackPoint(); //计算攻击力
        public abstract void calDefensePoint(); //计算防御力

    }
}
