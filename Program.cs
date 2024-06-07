using System.Threading.Tasks;

namespace EV7XLE
{
    public class Program
    {
        static void Main(string[] args)
        { 
            StreamReader file = new StreamReader("bemenet.txt");
            List<Elf> elfek = new List<Elf>();
            List<Ork> orkok = new List<Ork>();
            while (!file.EndOfStream)
            {
                var sor = file.ReadLine().Trim().Split(" ");
                switch (sor[1])
                {
                    case "o":
                        switch (sor[2])
                        {
                            case "v":
                                Vérengző vérengző = new Vérengző(sor[0], int.Parse(sor[3]));
                                orkok.Add(vérengző);
                                break;
                            case "r":
                                Ravasz ravasz = new Ravasz(sor[0], int.Parse(sor[3]));
                                orkok.Add(ravasz);
                                break;
                            case "o":
                                Óvatos óvatos = new Óvatos(sor[0], int.Parse(sor[3]));
                                orkok.Add(óvatos);
                                break;
                            default:
                                throw new ArgumentException("hibás bemenet");
                        }
                        break;
                    case "e":
                        switch (sor[2])
                        {
                            case "v":
                                Vakmerő vakmerő = new Vakmerő(sor[0]);
                                elfek.Add(vakmerő);
                                break;
                            case "u":
                                Ügyes ügyes = new Ügyes(sor[0]);
                                elfek.Add(ügyes);
                                break;
                            case "b":
                                Bölcs bölcs = new Bölcs(sor[0]);
                                elfek.Add(bölcs);
                                break;
                            default:
                                throw new ArgumentException("hibás bemenet");
                        }
                        break;
                    default:
                        throw new ArgumentException("hibás bemenet");
                }
            }
            Harc harc = new Harc(elfek, orkok);
            harc.Menet();
        }
    }
}
