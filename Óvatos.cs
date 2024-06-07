using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EV7XLE
{
    public class Óvatos : Ork
    {
        public Óvatos(string name, int kincs) : base(name, kincs) { }
        public override bool IsÓvatos()
        {
            return true;
        }
        public override int MaxÉleterő()
        {
            return 80;
        }
        public override int TámadóÉrték()
        {
            return 10;
        }
        public override int Pajzs()
        {
            return 15;
        }
        public override int Damage(Vakmerő v)
        {
            return 0;
        }
        public override int Damage(Bölcs b)
        {
            return 0;
        }
        public override int Damage(Ügyes b)
        {
            return 0;
        }

    }
}
