using DeskHub.Domain.Enums;

namespace DeskHub.Domain.Entities;

public class User
{
    public Guid Id { get; private set;}
    public string Name { get; set;}
    public string Email { get; set;}
    public Role Role { get; set;}

    private User() {}

    public User(Guid id, string name, string email, Role role)
    {
        Id = id;
        Name = name;
        Email = email;
        Role = role;
    }
}