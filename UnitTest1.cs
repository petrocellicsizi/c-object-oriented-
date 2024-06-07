namespace EV7XLE
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Kezd�StatokElfTest()
        {
            Vakmer� Alad�r = new Vakmer�("Alad�r");
            �gyes B�la = new �gyes("B�la");
            B�lcs Cecil = new B�lcs("Cecil");
            Assert.AreEqual(Alad�r.�leter�, 100);
            Assert.AreEqual(B�la.�leter�, 80);
            Assert.AreEqual(Cecil.�leter�, 60);
            Assert.AreEqual(Alad�r.T�mad��rt�k(), 30);
            Assert.AreEqual(B�la.T�mad��rt�k(), 20);
            Assert.AreEqual(Cecil.T�mad��rt�k(), 10);
        }
        [TestMethod]
        public void Kezd�StatokOrkTest()
        {
            V�rengz� Alad�r = new V�rengz�("Alad�r",30);
            Ravasz B�la = new Ravasz("B�la",10);
            �vatos Cecil = new �vatos("Cecil",20);
            Assert.AreEqual(Alad�r.�leter�, 100);
            Assert.AreEqual(B�la.�leter�, 90);
            Assert.AreEqual(Cecil.�leter�, 80);
            Assert.AreEqual(Alad�r.T�mad��rt�k(), 30);
            Assert.AreEqual(B�la.T�mad��rt�k(), 15);
            Assert.AreEqual(Cecil.T�mad��rt�k(), 10);
            Assert.AreEqual(Alad�r.kincs, 30);
            Assert.AreEqual(B�la.kincs, 10);
            Assert.AreEqual(Cecil.kincs, 20);
            Assert.AreEqual(Alad�r.Pajzs(), 5);
            Assert.AreEqual(B�la.Pajzs(), 20);
            Assert.AreEqual(Cecil.Pajzs(), 15);
        }
        [TestMethod]
        public void HealTest()
        {
            Vakmer� Alad�r = new Vakmer�("Alad�r");
            �gyes B�la = new �gyes("B�la");
            B�lcs Cecil = new B�lcs("Cecil");
            Alad�r.�leter� = 29;
            Alad�r.elix�r = 100;
            B�la.�leter� = 50;
            B�la.elix�r = 100;
            Cecil.�leter� = 10;
            Cecil.elix�r = 40;
            Assert.AreEqual(Alad�r.Heal�rt�k(), 1);
            Assert.AreEqual(B�la.Heal�rt�k(), 0);
            Assert.AreEqual(Cecil.Heal�rt�k(), 50);
            try
            {
                Alad�r.Heal();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            try
            {
                B�la.Heal();
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
            Assert.AreEqual(Alad�r.�leter�, 30);
            Assert.AreEqual(B�la.�leter�, 50);
            Assert.AreEqual(Cecil.�leter�, 50);
        }
        [TestMethod]
        public void KincsToElixirTest()
        {
            Vakmer� Alad�r = new Vakmer�("Alad�r");
            �gyes B�la = new �gyes("B�la");
            B�lcs Cecil = new B�lcs("Cecil");
            Alad�r.kincs = 100;
            B�la.kincs = 100;
            Cecil.kincs = 100;
            Alad�r.KincsToElix�r();
            B�la.KincsToElix�r();
            Cecil.KincsToElix�r();
            Assert.AreEqual(Alad�r.elix�r, 0);
            Assert.AreEqual(B�la.elix�r, 50);
            Assert.AreEqual(Cecil.elix�r, 100);

        }
        [TestMethod]
        public void KincsGatherTest()
        {
            Vakmer� N�ri = new Vakmer�("N�ri");
            Ravasz Peti = new Ravasz("Peti", 69);
            N�ri.KincsGather(Peti.kincs);
            Assert.AreEqual(N�ri.kincs, 69);
        }
        [TestMethod]
        public void T�madTest()
        {
            Vakmer� N�ri = new Vakmer�("N�ri");
            V�rengz� Peti = new V�rengz�("Peti", 30);
            N�ri.T�mad(Peti);
            Peti.T�mad(N�ri);
            Assert.AreEqual(Peti.�leter�, 75);
            Assert.AreEqual(N�ri.�leter�, 80);
        }
        [TestMethod]
        public void L�togat�tervTest() 
        {
            Vakmer� N�ri = new Vakmer�("N�ri");
            V�rengz� Peti = new V�rengz�("Peti", 30);
            Assert.AreEqual(Peti.Damage(N�ri), 20);
        }
        [TestMethod]
        public void AllDied()
        {
            List<Ork> orks = new List<Ork>();
            List<Elf> elfs = new List<Elf>();
            Harc n�rihetevegen = new Harc(elfs, orks);
            Assert.IsTrue(n�rihetevegen.allElfDied());
            Assert.IsTrue(n�rihetevegen.allOrkDied());
        }
        [TestMethod]
        public void MenetTeszt()
        {
            V�rengz� Fal�nk = new V�rengz�("Fal�nk",17);
            V�rengz� K�pc�s = new V�rengz�("K�pc�s", 17);
            �gyes B�la = new �gyes("B�la");
            List<Ork> orks = new List<Ork>();
            List<Elf> elfs = new List<Elf>();
            elfs.Add(B�la);
            orks.Add(K�pc�s);
            orks.Add(Fal�nk);
            Harc n�rihetevegen = new Harc(elfs, orks);
            n�rihetevegen.Menet();
            Assert.AreEqual(n�rihetevegen.elfek.Count(), 0);

        }
    }
}