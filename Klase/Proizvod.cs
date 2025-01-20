sealed class Proizvod
{
    private int ID_Prozivoda;

    public string Naziv;
    public float Cijena;
    public string Opis;
    public float Popust;

    protected int kolicina;

    public Proizvod(int param_id, string param_naziv, float param_cijena, string param_opis, int param_kolicina)
    {
        this.ID_Prozivoda = param_id;
        this.Naziv = param_naziv;
        this.Cijena = param_cijena;
        this.Opis = param_opis;
        this.kolicina = param_kolicina;
    }

    public void povecaj_zalihe(int param_kolicina)
    {
        this.kolicina += param_kolicina;
    }

    public void smanji_zalihe(int param_kolicina)
    {
        this.kolicina -= param_kolicina;
    }

    public void postavi_zalihe(int param_kolicina)
    {
        this.kolicina = param_kolicina;
    }

    public void dodaj_popust(float param_popust)
    {
        if(param_popust < 0.0f || param_popust > 100.0f){
            this.Popust = 0.0f;
            throw new NotImplementedException();
        }
        this.Popust = param_popust;
    }

    public void makni_popust()
    {
        this.Popust = 0.0f;
    }
}
