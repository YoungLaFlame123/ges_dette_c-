public class ClientRepository : IClientRepository
{
    private readonly List<Client> _clients = new List<Client>();

    public void Ajouter(Client client)
    {
        _clients.Add(client);
    }

    public Client TrouverParId(int id)
    {
        return _clients.FirstOrDefault(c => c.Id == id);
    }

    public List<Client> ListerTous()
    {
        return _clients;
    }
}
