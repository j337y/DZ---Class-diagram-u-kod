sealed class Korpa
{
    private int ID_Korpe;

    public List<Proizvod> Lista_Proizvoda;

    public float Ukupna_Cijena;

    public void dodaj_proizvod(Proizvod param_proizvod)
    {
        Lista_Proizvoda.Add(param_proizvod);

        izracunaj_ukupno();

    }

    public void ukloni_proizvod(Proizvod param_proizvod)
    {
        Lista_Proizvoda.Remove(param_proizvod);

        izracunaj_ukupno();
    }

    public void izracunaj_ukupno()
    {
        Lista_Proizvoda.ForEach(proizvod => {
            this.Ukupna_Cijena = this.Ukupna_Cijena + Matematika.Izracunaj_Popust(proizvod);
        });
    }
}
