﻿using System;
using System.Collections.Generic;

namespace Library
{
    public class Frigate : AbstractVessel
    {
        public Frigate()
        : base(2, 1)
        {
            
        }
        public string Name()
        {
            return "Frigate";
        }
        public List<string> AttackForms()
        {
            return new List<string> {"LaunchMissile"};
        }
        public override void LaunchMissile(AbstractTable table, int x1, int y1, int x2, int y2)
        {
            AbstractAttacker missile1 = new MissileAttack();
            AbstractAttacker missile2 = new MissileAttack();
            AbstractAttacker missile3 = new MissileAttack();
            AbstractAttacker missile4 = new MissileAttack();
            table.AttackAt(x1, y1, missile1);
            table.AttackAt(x2, y2, missile2);
            table.RandomAttack(missile3);
            table.RandomAttack(missile4);
        }
    }
}