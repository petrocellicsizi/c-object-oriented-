using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EV7XLE
{
    public class Bölcs : Elf
    {
        public Bölcs(string name) : base(name)
        {
            életerő = MaxÉleterő();
        }
        public override bool IsBölcs()
        {
            return true;
        }
        public override int MaxÉleterő()
        {
            return 60;
        }
        public override int TámadóÉrték()
        {
            return 10;
        }
        public override void KincsToElixír()
        {
            elixír += kincs;
            kincs = 0;
        }
        public override int HealÉrték()
        {
            return (60-életerő);
        }
        public override void Védekez(Ork o)
        {
            életerő -= o.Damage(this);
        }
    }
}
