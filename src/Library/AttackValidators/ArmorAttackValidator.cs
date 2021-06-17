﻿namespace Library
{
    public class ArmorAttackValidator : IAttackValidator
    {
        public ArmorAttackValidator()
        {

        }
        public bool AvoidAttack(ITable table, AbstractAttacker attack)
        {
            return (attack is MissileAttack || attack is LoadAttack);
        }
    }
}