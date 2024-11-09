public interface IClientRepository
{
    void Ajouter(Client client);
    Client TrouverParId(int id);
    List<Client> ListerTous();
}
