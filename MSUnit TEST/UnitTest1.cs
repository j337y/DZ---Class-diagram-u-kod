namespace MSUnitTest.Classes
{
    [TestClass]
    public class KorisnikTests
    {
        [TestMethod]
        public void TestRegistracijaIspravna()
        {
            // Arrange
            var korisnik = new Korisnik();

            // Act
            var isRegistriran = korisnik.registracija("Marko", "marko@email.com", "Lozinka123");

            // Assert
            Assert.IsTrue(isRegistriran);
            Assert.IsTrue(korisnik.registriran);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRegistracijaNeispravnaEmail()
        {
            // Arrange
            var korisnik = new Korisnik();

            // Act & Assert
            korisnik.registracija("Marko", "invalidemail", "Lozinka123"); // Neispravan email
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRegistracijaPrekratkaLozinka()
        {
            // Arrange
            var korisnik = new Korisnik();

            // Act & Assert
            korisnik.registracija("Marko", "marko@email.com", "123"); // Prekratka lozinka
        }

        [TestMethod]
        public void TestPrijavaIspravna()
        {
            // Arrange
            var korisnik = new Korisnik();
            korisnik.registracija("Marko", "marko@email.com", "Lozinka123");

            // Act
            var isPrijavljen = korisnik.prijava("marko@email.com", "Lozinka123");

            // Assert
            Assert.IsTrue(isPrijavljen);
            Assert.IsTrue(korisnik.prijavljen);
        }

        [TestMethod]
        public void TestPrijavaNeispravna()
        {
            // Arrange
            var korisnik = new Korisnik();
            korisnik.registracija("Marko", "marko@email.com", "Lozinka123");

            // Act
            var isPrijavljen = korisnik.prijava("marko@email.com", "PogresnaLozinka");

            // Assert
            Assert.IsFalse(isPrijavljen);
            Assert.IsFalse(korisnik.prijavljen);
        }
    }




    [TestClass]
    public class ProizvodTests
    {
        [TestMethod]
        public void TestProizvodKreiranjeIspravno()
        {
            // Arrange & Act
            var proizvod = new Proizvod(1, "Laptop", 1000.00f, "Brzi laptop", 10);

            // Assert
            Assert.AreEqual("Laptop", proizvod.Naziv);
            Assert.AreEqual(1000.00f, proizvod.Cijena);
            Assert.AreEqual("Brzi laptop", proizvod.Opis);
            Assert.AreEqual(10, proizvod.kolicina);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestProizvodKreiranjeNegativnaCijena()
        {
            // Act
            var proizvod = new Proizvod(1, "Laptop", -1000.00f, "Brzi laptop", 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestProizvodKreiranjeNegativnaKolicina()
        {
            // Act
            var proizvod = new Proizvod(1, "Laptop", 1000.00f, "Brzi laptop", -5);
        }

        [TestMethod]
        public void TestPopustPostavljanje()
        {
            // Arrange
            var proizvod = new Proizvod(1, "Laptop", 1000.00f, "Brzi laptop", 10);

            // Act
            proizvod.Popust = 20;

            // Assert
            Assert.AreEqual(20, proizvod.Popust);
        }



    }




    [TestClass]
    public class NarudzbaTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNarudzbaKreiranjeNeispravanKorisnik()
        {
            // Arrange
            var korisnik = new Korisnik();
            var narudzba = new Narudzba(korisnik);  // Korisnik nije registriran i prijavljen
        }

        [TestMethod]
        public void TestNarudzbaKreiranjeIspravanKorisnik_ReturnsTrue()
        {
            // Arrange
            var korisnik = new Korisnik();
            korisnik.registracija("Marko", "marko@email.com", "Lozinka123");
            korisnik.prijava("marko@email.com", "Lozinka123");

            // Act
            var narudzba = new Narudzba(korisnik);

            // Assert
            Assert.IsNotNull(narudzba);
        }

        [TestMethod]
        public void TestDodajProizvod()
        {
            // Arrange
            var korisnik = new Korisnik();
            korisnik.registracija("Marko", "marko@email.com", "Lozinka123");
            korisnik.prijava("marko@email.com", "Lozinka123");
            var narudzba = new Narudzba(korisnik);

            var proizvod = new Proizvod(1, "Laptop", 1000.00f, "Brzi laptop", 10);

            // Act
            narudzba.dodaj_proizvod(proizvod);

            // Assert
            Assert.AreEqual(1, narudzba.Lista_Proizvoda.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIzbrisiProizvodKojiNePostoji()
        {
            // Arrange
            var korisnik = new Korisnik();
            korisnik.registracija("Marko", "marko@email.com", "Lozinka123");
            var narudzba = new Narudzba(korisnik);

            var proizvod = new Proizvod(1, "Laptop", 1000.00f, "Brzi laptop", 10);

            // Act & Assert
            narudzba.izbrisi_proizvod(proizvod); 
        }

        [TestMethod]
        public void TestPotvrdiNarudzbu_ReturnsTrue()
        {
            // Arrange
            var korisnik = new Korisnik();
            korisnik.registracija("Marko", "marko@email.com", "Lozinka123");
            korisnik.prijava("marko@email.com", "Lozinka123");
            var narudzba = new Narudzba(korisnik);

            var proizvod = new Proizvod(1, "Laptop", 1000.00f, "Brzi laptop", 10);
            narudzba.dodaj_proizvod(proizvod);

            // Act
            var potvrda = narudzba.potvrdi_narudzbu();

            // Assert
            Assert.IsTrue(potvrda);
        }
    }



}