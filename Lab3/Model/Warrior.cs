using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3.Model
{
    class Warrior:Hero,ISuperAttack
    {
        public override void calAttackPoint()
        {
            //SuperAttack();
            this.AttackPoint = this.IntellgencePoint / 2 + this.StrengthPoint + weapon.attackPoint * 2;
            weapon.lucky = weapon.lucky + 1;
        }
        public override void calDefensePoint()
        {
            this.DefensePoint = this.IntellgencePoint / 4 + this.StrengthPoint / 2 + weapon.defensePoint;
        }
        public void SuperAttack()
        {
            if (this.weapon.attackPoint != 0 && this.weapon.attackPoint != 0)
            {
                if (this.weapon.lucky > 5 && this.hp < 70)
                {
                    this.AttackPoint = this.IntellgencePoint*2 + this.StrengthPoint*2 + weapon.attackPoint;
                    this.weapon.lucky = 3;
                }   
            }
            else
            {
                this.AttackPoint = this.IntellgencePoint / 2 + this.StrengthPoint + weapon.attackPoint * 2;
                weapon.lucky = weapon.lucky + 1;
            }
        }
    }
}
