sealed public class Narudzba
{
    public static int Broj_instanciranih_objekata { get; private set; }
    private int ID_Narudzbe;

    public int Datum;
    public string Status;
    public List<Proizvod> Lista_Proizvoda;

    private Korisnik korisnik_koji_narucuje;

    public Narudzba(Korisnik param_korisnik)
    {
        if (param_korisnik == null || !param_korisnik.prijavljen || !param_korisnik.registriran)
        {
            throw new ArgumentException("Korisnik mora biti registriran i prijavljen da bi mogao naruciti!");
        }
        this.Lista_Proizvoda = new List<Proizvod>();

        Broj_instanciranih_objekata++;
        this.ID_Narudzbe = Broj_instanciranih_objekata;
        this.korisnik_koji_narucuje = param_korisnik;
    }

    public void dodaj_proizvod(Proizvod param_proizvod)
    {
        if (param_proizvod == null)
        {
            throw new ArgumentNullException("Proizvod ne može biti null");
        }

        if (!this.Lista_Proizvoda.Contains(param_proizvod))
        {
            this.Lista_Proizvoda.Add(param_proizvod);
        }
        else
        {
            throw new ArgumentException("Proizvod je već u narudzbi");
        }
    }

    public void izbrisi_proizvod(Proizvod param_proizvod)
    {
        if (param_proizvod == null)
        {
            throw new ArgumentNullException("Proizvod ne moze biti null");
        }

        if (Lista_Proizvoda.Contains(param_proizvod))
        {
            Lista_Proizvoda.Remove(param_proizvod);
        }
        else
        {
            throw new ArgumentException("Proizvod nije pronaden u narudzbi");
        }
    }

    public bool potvrdi_narudzbu()
    {
        if (Lista_Proizvoda.Count == 0)
        {
            throw new InvalidOperationException("Narudzba mora sadrzavati najmanje jedan proizvod");
        }

        return true;
    }
}
