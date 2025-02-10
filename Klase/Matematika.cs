static public class Matematika
{
    public static float Izracunaj_Popust(Proizvod param_proizvod)
    {
       return (param_proizvod.Cijena * param_proizvod.Popust / 100);
    }
}
