sealed public class Administrator : Korisnik
{
    private Proizvod dodaj_proizvod(int param_id, string param_naziv, float param_cijena, string param_opis, int param_kolicina)
    {
        if (param_cijena <= 0 || param_kolicina < 0)
        {
            throw new ArgumentException("Cijena mora biti pozitivna, a kolicina ne može biti negativna");
        }
        return new Proizvod(param_id, param_naziv, param_cijena, param_opis, param_kolicina);
    }

    private void povecaj_zalihe(Proizvod proizvod, int param_kolicina)
    {
        if (param_kolicina < 0)
        {
            throw new ArgumentException("Kolicina ne moze biti negativna");
        }

        proizvod.kolicina += param_kolicina;
    }

    private void smanji_zalihe(Proizvod proizvod, int param_kolicina)
    {
        if (param_kolicina < 0 || proizvod.kolicina < param_kolicina)
        {
            throw new ArgumentException("Ne mozete smanjiti kolicinu na negativnu vrijednost");
        }

        proizvod.kolicina -= param_kolicina;
    }

    private void postavi_zalihe(Proizvod proizvod, int param_kolicina)
    {
        if (param_kolicina < 0)
        {
            throw new ArgumentException("Kolicina ne moze biti negativna");
        }

        proizvod.kolicina = param_kolicina;
    }

    private void dodaj_popust(Proizvod proizvod, float param_popust)
    {
        if (param_popust < 0.0f || param_popust > 100.0f)
        {
            throw new ArgumentException("Popust mora biti izmedu 0 i 10.");
        }

        proizvod.Popust = param_popust;

    }

    private void makni_popust(Proizvod proizvod)
    {
        proizvod.Popust = 0.0f;
    }

}
