public class Korisnik
{
    private static int Broj_instanciranih_objekata = 0;
    private int ID_Korisnika;

    protected string Ime;
    private string Lozinka;
    protected string Email;

    public bool prijavljen { get; private set; }
    public bool registriran { get; private set; }

    public Korisnik()
    {
        Broj_instanciranih_objekata++;
        this.ID_Korisnika = Broj_instanciranih_objekata;
    }

    public bool prijava(string param_mail, string param_lozinka)
    {
        if (this.registriran)
        {
            if (this.Email == param_mail && this.Lozinka == param_lozinka)
            {
                this.prijavljen = true;
                return true;
            }
            return false;
        }

        return false;
    }

    public bool odjava()
    {
        if (this.prijavljen)
        {
            this.prijavljen = false;
            return true;
        }

        return false;
    }

    public bool registracija(string param_ime, string param_mail, string param_lozinka)
    {
        if (this.registriran)
        {
            return false;
        }

        if (param_ime.Length == 0 || param_mail.Length == 0 || param_lozinka.Length == 0)
        {
            throw new ArgumentException("Ime, email i lozinka ne smiju biti prazni");
        }

        if (!param_mail.Contains("@"))
        {
            throw new ArgumentException("Nevazeci email format");
        }

        if (param_lozinka.Length < 6)
        {
            throw new ArgumentException("Lozinka mora biti barem 6 znakova duga");
        }

        this.Ime = param_ime;
        this.Email = param_mail;
        this.Lozinka = param_lozinka;
        this.registriran = true;

        return true;
    }
}