using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EV7XLE
{
    public class Harc
    {
        int menetcount = 1;
        public Harc(List<Elf> elfek, List<Ork> orkok) 
        {
            this.elfek = elfek;
            this.orkok = orkok;
        }
        public List<Elf> elfek = new List<Elf>();
        public List<Ork> orkok = new List<Ork>();
        public bool allOrkDied() 
        {
            return (orkok.Count() == 0);
        }
        public bool allElfDied()
        {
            return (elfek.Count() == 0);
        }
        public void Menet()
        {
            while (allOrkDied()==false && allElfDied()==false)
            {
                foreach (Elf e in elfek) 
                {
                    if (allOrkDied() || allElfDied()) break;
                    var random = new Random();
                    int x = random.Next(orkok.Count());
                    e.Támad(orkok[x]);
                    if (orkok[x].getÉleterő()<=0)
                    {
                        e.KincsGather(orkok[x].getKincs());
                        orkok.Remove(orkok[x]);
                    }
                }
                foreach (Ork o in orkok)
                {
                    if (allOrkDied() || allElfDied()) break;
                    var random = new Random();
                    int x = random.Next(elfek.Count());
                    o.Támad(elfek[x]);
                    if (elfek[x].getÉleterő()<= 0)
                    {
                        o.gyilkolt();
                        elfek.Remove(elfek[x]);
                    }
                }
                foreach (Elf e in elfek)
                {
                    e.KincsToElixír();
                    try
                    {
                        e.Heal();
                    }
                    catch (Exception exp)
                    {
                        //  Block of code to handle errors
                    }
                }
                Console.WriteLine("Menetszám:"+menetcount);
                menetcount++;
                foreach(Elf e in elfek)
                {
                    if (e.IsBölcs()) Console.WriteLine(string.Format("{0} élet:{1} Bölcs killszám:{2}", e.name, e.életerő, e.killcount));
                    if (e.IsVakmerő()) Console.WriteLine(string.Format("{0} élet:{1} Vakmerő killszám:{2}", e.name, e.életerő, e.killcount));
                    if (e.IsÜgyes()) Console.WriteLine(string.Format("{0} élet:{1} Ügyes killszám:{2}", e.name, e.életerő, e.killcount));
                }
                foreach (Ork o in orkok)
                {
                    if (o.IsVérengző()) Console.WriteLine(string.Format("{0} élet:{1} Vérengző killszám:{2}", o.name, o.életerő, o.killcount));
                    if (o.IsRavasz()) Console.WriteLine(string.Format("{0} élet:{1} Ravasz killszám:{2}", o.name, o.életerő, o.killcount));
                    if (o.IsÓvatos()) Console.WriteLine(string.Format("{0} élet:{1} Óvatos killszám:{2}", o.name, o.életerő, o.killcount));
                }
                Console.WriteLine(" ");
                if(allElfDied()==true && allOrkDied()==false) Console.WriteLine("orkok nyertek");
                if (allElfDied() == false && allOrkDied() == true) Console.WriteLine("elfek nyertek");
                if (menetcount > 100) 
                { 
                    Console.WriteLine("döntetlen");
                    break;
                }
            }
        }
    }
}
