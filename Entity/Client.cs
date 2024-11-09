public class Client
{
    public int Id { get; private set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string Adresse { get; set; }
    public string Telephone { get; set; }
    
    private static int _compteur = 1;

    public Client(string nom, string prenom, string adresse, string telephone)
    {
        Id = _compteur++;
        Nom = nom;
        Prenom = prenom;
        Adresse = adresse;
        Telephone = telephone;
    }
}
