using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EV7XLE
{
    public class Elf
    {
        public string name;
        public int életerő;
        public int elixír;
        public int kincs;
        public int killcount=0;

        public int getÉleterő() { return életerő; }
        public Elf(string name)
        {
            this.name = name;
            életerő = MaxÉleterő();
        }
        public virtual void Védekez(Ork o) { }
        public virtual void KincsToElixír() { }
        public virtual int HealÉrték() { return 0; }
        public virtual int TámadóÉrték() { return 0; }
        public virtual int MaxÉleterő() { return 0; }
        public virtual bool IsVakmerő() { return false; }
        public virtual bool IsÜgyes() { return false; }
        public virtual bool IsBölcs() { return false; }
        public void Támad(Ork o) { o.Védekez(this); }
        public void Heal()
        {
            if (HealÉrték() == 0)
            {
                throw new Exception("nem kell heal");
            }
            if (HealÉrték() >= elixír)
            {
                életerő += elixír;
                elixír = 0;
            }
            if (HealÉrték() < elixír)
            {
                életerő += HealÉrték();
                elixír -= HealÉrték();
            }
        }
        public void KincsGather(int x) 
        { 
            kincs += x; 
            killcount++;
        }
    }
}
