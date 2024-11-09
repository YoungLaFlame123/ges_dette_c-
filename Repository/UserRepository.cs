public class UserRepository : IUserRepository
{
    private readonly List<User> _users = new List<User>();

    public void Ajouter(User user)
    {
        _users.Add(user);
    }

    public User TrouverParClientId(int clientId)
    {
        return _users.FirstOrDefault(u => u.ClientId == clientId);
    }

    public List<User> ListerTous()
    {
        return _users;
    }
}
