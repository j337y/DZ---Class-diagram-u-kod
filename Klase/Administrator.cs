sealed class Administrator : Korisnik
{
    private Proizvod dodaj_proizvod(int param_id, string param_naziv, float param_cijena, string param_opis, int param_kolicina)
    {
        return new Proizvod(param_id, param_naziv, param_cijena, param_opis, param_kolicina);
    }

    private void azuriraj_proizvod(Proizvod param_proizvod)
    {
        throw new NotImplementedException();
    }

    private void ukloni_proizvod(int param_id_proizvoda)
    {
        throw new NotImplementedException();
    }
}
