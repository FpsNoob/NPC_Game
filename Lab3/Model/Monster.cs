using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3.Model
{
    class Monster
    {
        public string name;
        public int oldX;
        public int oldY;
        public int newX;
        public int newY;
        public int hp;
        public int attackPoint;
        public int defensePoint;


        public void move(Hero hero)
        {
            newX = hero.oldX + 125;
            newY = hero.oldY;
            hero.calDefensePoint();
            hero.calDefensePoint();
            int offset =attackPoint - hero.DefensePoint;
            if (offset > 0)
            {
                hero.hp = hero.hp - attackPoint+hero.DefensePoint;
            }
        }
        virtual public void back()
        {
            newX = oldX;
            newY = oldY;
        }
    }
}
