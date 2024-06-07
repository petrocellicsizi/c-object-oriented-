using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EV7XLE
{
    public class Ügyes : Elf
    {
        public Ügyes(string name) : base(name)
        {
            életerő = MaxÉleterő();
        }
        public override bool IsÜgyes()
        {
            return true;
        }
        public override int MaxÉleterő()
        {
            return 80;
        }
        public override int TámadóÉrték()
        {
            return 20;
        }
        public override void KincsToElixír()
        {
            elixír += kincs/2;
            kincs = kincs / 2;
        }
        public override int HealÉrték()
        {
            if (életerő < 50) { return 50 - életerő; }
            else { return 0; }
        }
        public override void Védekez(Ork o)
        {
            életerő -= o.Damage(this);
        }
    }
}
