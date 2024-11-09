public class User
{
    public int Id { get; private set; }
    public int ClientId { get; private set; }
    public string Username { get; set; }
    public string Password { get; set; }
    
    private static int _compteur = 1;

    public User(int clientId, string username, string password)
    {
        Id = _compteur++;
        ClientId = clientId;
        Username = username;
        Password = password;
    }
}
