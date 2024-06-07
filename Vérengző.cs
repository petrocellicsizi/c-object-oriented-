using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EV7XLE
{
    public class Vérengző : Ork
    {
        public Vérengző(string name, int kincs) : base(name, kincs) { }
        public override bool IsVérengző()
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
        public override int Pajzs()
        {
            return 5;
        }
        public override int Damage(Vakmerő v)
        {
            return 20;
        }
        public override int Damage(Bölcs b)
        {
            return 10;
        }
        public override int Damage(Ügyes b)
        {
            return 20;
        }
    }
}
