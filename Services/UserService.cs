public class UserService
{
    private readonly IUserRepository _userRepository;
    private readonly IClientRepository _clientRepository;

    public UserService(IUserRepository userRepository, IClientRepository clientRepository)
    {
        _userRepository = userRepository;
        _clientRepository = clientRepository;
    }

    public User CreerUser(int clientId, string username, string password)
    {
        var client = _clientRepository.TrouverParId(clientId);
        if (client == null)
        {
            throw new Exception("Client non trouvé");
        }

        var user = new User(clientId, username, password);
        _userRepository.Ajouter(user);
        return user;
    }

    public List<User> ListerUsers()
    {
        return _userRepository.ListerTous();
    }
}
