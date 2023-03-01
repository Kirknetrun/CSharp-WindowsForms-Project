using Microsoft.VisualStudio.TestTools.UnitTesting;
using proj;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSrednieSpalanie()
        {
            double iloscPaliwa1 = 10,
                kilometry1 = 100,
                iloscPaliwa2 = 20,
                kilometry2 = 200,
                srednia1,
                srednia2;

            srednia1 = Form1.SrednieSpalanie(iloscPaliwa1, kilometry1);
            srednia2 = Form1.SrednieSpalanie(iloscPaliwa2, kilometry2);

            Assert.AreEqual(srednia1, srednia2);
        }

        [TestMethod]
        public void TestCenaZaCalaTrase()
        {
            double cenaZaStoKm1 = 3,
                kilometry1 = 200,
                cenaZaStoKm2 = 6,
                kilometry2 = 100,
                cena1,
                cena2;

            cena1 = Form1.CenaZaCalaTrase(cenaZaStoKm1, kilometry1);
            cena2 = Form1.CenaZaCalaTrase(cenaZaStoKm2, kilometry2);

            Assert.AreEqual(cena1, cena2);
        }
    }
}