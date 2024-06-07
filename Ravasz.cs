using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EV7XLE
{
    public class Ravasz : Ork
    {
        public Ravasz(string name, int kincs) : base(name, kincs) { }
        public override bool IsRavasz()
        {
            return true;
        }
        public override int MaxÉleterő()
        {
            return 90;
        }
        public override int TámadóÉrték()
        {
            return 15;
        }
        public override int Pajzs()
        {
            return 20;
        }
        public override int Damage(Vakmerő v)
        {
            return 5;
        }
        public override int Damage(Bölcs b)
        {
            return 0;
        }
        public override int Damage(Ügyes b)
        {
            return 5;
        }
    }
}
