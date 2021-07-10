using System;
using System.Collections.ObjectModel;

namespace Library
{
    public class KongNextItem : AbstractNextItem
    {
        public KongNextItem()
        :base(new SateliteLockNextItem())
        {
        }
        public override IItem NextItem(int random)
        {
            if (random == 3)
            {
                return new AntiaircraftMissile();
            }
            else
            {
                return this.SendNext(random);
            }
        }
    }
}