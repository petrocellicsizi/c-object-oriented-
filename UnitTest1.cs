namespace EV7XLE
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void KezdõStatokElfTest()
        {
            Vakmerõ Aladár = new Vakmerõ("Aladár");
            Ügyes Béla = new Ügyes("Béla");
            Bölcs Cecil = new Bölcs("Cecil");
            Assert.AreEqual(Aladár.életerõ, 100);
            Assert.AreEqual(Béla.életerõ, 80);
            Assert.AreEqual(Cecil.életerõ, 60);
            Assert.AreEqual(Aladár.TámadóÉrték(), 30);
            Assert.AreEqual(Béla.TámadóÉrték(), 20);
            Assert.AreEqual(Cecil.TámadóÉrték(), 10);
        }
        [TestMethod]
        public void KezdõStatokOrkTest()
        {
            Vérengzõ Aladár = new Vérengzõ("Aladár",30);
            Ravasz Béla = new Ravasz("Béla",10);
            Óvatos Cecil = new Óvatos("Cecil",20);
            Assert.AreEqual(Aladár.életerõ, 100);
            Assert.AreEqual(Béla.életerõ, 90);
            Assert.AreEqual(Cecil.életerõ, 80);
            Assert.AreEqual(Aladár.TámadóÉrték(), 30);
            Assert.AreEqual(Béla.TámadóÉrték(), 15);
            Assert.AreEqual(Cecil.TámadóÉrték(), 10);
            Assert.AreEqual(Aladár.kincs, 30);
            Assert.AreEqual(Béla.kincs, 10);
            Assert.AreEqual(Cecil.kincs, 20);
            Assert.AreEqual(Aladár.Pajzs(), 5);
            Assert.AreEqual(Béla.Pajzs(), 20);
            Assert.AreEqual(Cecil.Pajzs(), 15);
        }
        [TestMethod]
        public void HealTest()
        {
            Vakmerõ Aladár = new Vakmerõ("Aladár");
            Ügyes Béla = new Ügyes("Béla");
            Bölcs Cecil = new Bölcs("Cecil");
            Aladár.életerõ = 29;
            Aladár.elixír = 100;
            Béla.életerõ = 50;
            Béla.elixír = 100;
            Cecil.életerõ = 10;
            Cecil.elixír = 40;
            Assert.AreEqual(Aladár.HealÉrték(), 1);
            Assert.AreEqual(Béla.HealÉrték(), 0);
            Assert.AreEqual(Cecil.HealÉrték(), 50);
            try
            {
                Aladár.Heal();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            try
            {
                Béla.Heal();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            try
            {
                Cecil.Heal();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            Assert.AreEqual(Aladár.életerõ, 30);
            Assert.AreEqual(Béla.életerõ, 50);
            Assert.AreEqual(Cecil.életerõ, 50);
        }
        [TestMethod]
        public void KincsToElixirTest()
        {
            Vakmerõ Aladár = new Vakmerõ("Aladár");
            Ügyes Béla = new Ügyes("Béla");
            Bölcs Cecil = new Bölcs("Cecil");
            Aladár.kincs = 100;
            Béla.kincs = 100;
            Cecil.kincs = 100;
            Aladár.KincsToElixír();
            Béla.KincsToElixír();
            Cecil.KincsToElixír();
            Assert.AreEqual(Aladár.elixír, 0);
            Assert.AreEqual(Béla.elixír, 50);
            Assert.AreEqual(Cecil.elixír, 100);

        }
        [TestMethod]
        public void KincsGatherTest()
        {
            Vakmerõ Nóri = new Vakmerõ("Nóri");
            Ravasz Peti = new Ravasz("Peti", 69);
            Nóri.KincsGather(Peti.kincs);
            Assert.AreEqual(Nóri.kincs, 69);
        }
        [TestMethod]
        public void TámadTest()
        {
            Vakmerõ Nóri = new Vakmerõ("Nóri");
            Vérengzõ Peti = new Vérengzõ("Peti", 30);
            Nóri.Támad(Peti);
            Peti.Támad(Nóri);
            Assert.AreEqual(Peti.életerõ, 75);
            Assert.AreEqual(Nóri.életerõ, 80);
        }
        [TestMethod]
        public void LátogatótervTest() 
        {
            Vakmerõ Nóri = new Vakmerõ("Nóri");
            Vérengzõ Peti = new Vérengzõ("Peti", 30);
            Assert.AreEqual(Peti.Damage(Nóri), 20);
        }
        [TestMethod]
        public void AllDied()
        {
            List<Ork> orks = new List<Ork>();
            List<Elf> elfs = new List<Elf>();
            Harc nórihetevegen = new Harc(elfs, orks);
            Assert.IsTrue(nórihetevegen.allElfDied());
            Assert.IsTrue(nórihetevegen.allOrkDied());
        }
        [TestMethod]
        public void MenetTeszt()
        {
            Vérengzõ Falánk = new Vérengzõ("Falánk",17);
            Vérengzõ Köpcös = new Vérengzõ("Köpcös", 17);
            Ügyes Béla = new Ügyes("Béla");
            List<Ork> orks = new List<Ork>();
            List<Elf> elfs = new List<Elf>();
            elfs.Add(Béla);
            orks.Add(Köpcös);
            orks.Add(Falánk);
            Harc nórihetevegen = new Harc(elfs, orks);
            nórihetevegen.Menet();
            Assert.AreEqual(nórihetevegen.elfek.Count(), 0);

        }
    }
}