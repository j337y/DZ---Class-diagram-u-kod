sealed public class Proizvod
{
    public static int Broj_instanciranih_objekata { get; private set; }
    public int ID_Prozivoda;

    public string Naziv;
    public float Cijena;
    public string Opis;
    public float Popust;

    public int kolicina;

    public Proizvod(int param_id, string param_naziv, float param_cijena, string param_opis, int param_kolicina)
    {
        if (param_cijena < 0)
        {
            throw new ArgumentException("Cijena ne moze biti negativna.");
        }

        if (param_kolicina < 0)
        {
            throw new ArgumentException("Kolicina ne moze biti negativna");
        }

        Broj_instanciranih_objekata++;
        this.ID_Prozivoda = Broj_instanciranih_objekata;
        this.Naziv = param_naziv;
        this.Cijena = param_cijena;
        this.Opis = param_opis;
        this.kolicina = param_kolicina;
    }
}
