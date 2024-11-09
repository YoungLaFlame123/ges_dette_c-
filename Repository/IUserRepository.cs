public interface IUserRepository
{
    void Ajouter(User user);
    User TrouverParClientId(int clientId);
    List<User> ListerTous();
}
