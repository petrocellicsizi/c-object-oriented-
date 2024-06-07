using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EV7XLE
{
    public class Ork
    {
        public string name;
        public int életerő;
        public int kincs;
        public int killcount=0;
        public void gyilkolt() { killcount++; }

        public int getÉleterő() { return életerő; }
        public int getKincs() { return kincs; }
        public Ork(string name, int kincs)
        {
            this.name = name;
            this.kincs = kincs;
            életerő = MaxÉleterő();
        }
        public void Védekez(Elf e)
        {
            if (Pajzs()<e.TámadóÉrték()) életerő-=e.TámadóÉrték()-Pajzs();
        }
        public virtual int TámadóÉrték() { return 0; }
        public virtual int MaxÉleterő() { return 0; }
        public virtual int Pajzs() { return 0; }
        public virtual bool IsVérengző() { return false; }
        public virtual bool IsRavasz() { return false; }
        public virtual bool IsÓvatos() { return false; }
        public void Támad(Elf e) { e.Védekez(this); }
        public virtual int Damage(Vakmerő v) { return 0; }
        public virtual int Damage(Bölcs b) { return 0; }
        public virtual int Damage(Ügyes ü) { return 0; }
    }
}
