sealed class Narudzba
{
    private int ID_Narudzbe;

    public int Datum;
    public string Status;
    public List<Proizvod> Lista_Proizvoda;

    public bool potvrdi_narudzbu()
    {
        throw new NotImplementedException();
    }

    public bool otkazi_narudzbu()
    {
        throw new NotImplementedException();
    }
}
