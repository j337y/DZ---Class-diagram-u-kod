class Korisnik
{
    private int ID_Korisnika;

    protected string Ime;
    private string Lozinka;

    protected string Email;

    public Korisnik()
    {
        this.ID_Korisnika = 0;

        this.Ime = "null";
        this.Lozinka = "";

        this.Email = "null";
    }

    public Korisnik(int param_id, string param_ime, string param_lozinka, string param_email)
    {
        this.ID_Korisnika = param_id;
        this.Ime = param_ime;
        this.Lozinka = param_lozinka;
        this.Email = param_email;
    }

    public bool prijava(string param_mail, string param_lozinka)
    {
        throw new NotImplementedException();
    }

    public bool registracija(string param_ime, string param_mail, string param_lozinka)
    {
        throw new NotImplementedException();
    }
}