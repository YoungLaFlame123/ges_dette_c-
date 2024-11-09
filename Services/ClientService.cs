public class ClientService
{
    private readonly IClientRepository _clientRepository;

    public ClientService(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public Client CreerClient(string nom, string prenom, string adresse, string telephone)
    {
        var client = new Client(nom, prenom, adresse, telephone);
        _clientRepository.Ajouter(client);
        return client;
    }

    public List<Client> ListerClients()
    {
        return _clientRepository.ListerTous();
    }
}
