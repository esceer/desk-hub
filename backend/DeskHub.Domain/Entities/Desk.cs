namespace DeskHub.Domain.Entities;

public class Desk
{
    public Guid Id { get; private set;}
    public string Code { get; private set;}
    public bool IsActive { get; set;}

    private Desk() {}

    public Desk(Guid id, string code, bool isActive)
    {
        Id = id;
        Code = code;
        IsActive = isActive;
    }
}