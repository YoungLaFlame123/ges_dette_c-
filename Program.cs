class Program
{
    static void Main(string[] args)
    {
        // Créer les repositories
        IClientRepository clientRepository = new ClientRepository();
        IUserRepository userRepository = new UserRepository();

        // Créer les services
        ClientService clientService = new ClientService(clientRepository);
        UserService userService = new UserService(userRepository, clientRepository);

        // Création d'un client
        Console.WriteLine("Création d'un client:");
        Console.Write("Entrez le nom: ");
        string nom = Console.ReadLine();
        
        Console.Write("Entrez le prénom: ");
        string prenom = Console.ReadLine();
        
        Console.Write("Entrez l'adresse: ");
        string adresse = Console.ReadLine();
        
        Console.Write("Entrez le téléphone: ");
        string telephone = Console.ReadLine();

        Client client = clientService.CreerClient(nom, prenom, adresse, telephone);
        Console.WriteLine($"Client créé avec ID: {client.Id}");

        // Création d'un utilisateur pour le client
        Console.WriteLine("\nCréation d'un utilisateur pour le client:");
        Console.Write("Entrez le nom d'utilisateur: ");
        string username = Console.ReadLine();
        
        Console.Write("Entrez le mot de passe: ");
        string password = Console.ReadLine();

        User user = userService.CreerUser(client.Id, username, password);
        Console.WriteLine($"Utilisateur créé avec ID: {user.Id} pour le client ID: {client.Id}");
        
        // Lister les clients et utilisateurs
        Console.WriteLine("\nListe des clients:");
        foreach (var c in clientService.ListerClients())
        {
            Console.WriteLine($"ID: {c.Id}, Nom: {c.Nom}, Prénom: {c.Prenom}");
        }

        Console.WriteLine("\nListe des utilisateurs:");
        foreach (var u in userService.ListerUsers())
        {
            Console.WriteLine($"ID: {u.Id}, ClientID: {u.ClientId}, Nom d'utilisateur: {u.Username}");
        }
    }
}
