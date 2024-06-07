using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EV7XLE
{
    public class Vakmerő : Elf
    {
        public Vakmerő(string name ) : base(name) 
        {
            életerő = MaxÉleterő();
        }
        public override bool IsVakmerő()
        {
            return true;
        }
        public override int MaxÉleterő()
        {
            return 100;
        }
        public override int TámadóÉrték()
        {
            return 30;
        }
        public override void KincsToElixír()
        {
            base.KincsToElixír();
        }
        public override int HealÉrték()
        {
            if (életerő < 30) { return 30-életerő; }
            else { return 0; }
        }
        public override void Védekez(Ork o)
        {
            életerő -= o.Damage(this);
        }
    }
}
