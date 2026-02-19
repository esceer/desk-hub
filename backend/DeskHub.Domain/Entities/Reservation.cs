using DeskHub.Domain.Enums;
using DeskHub.Domain.ValueObjects;

namespace DeskHub.Domain.Entities;

public class Reservation
{
    public Guid Id { get; private set; }
    public Guid UserId { get; private set; }
    public Guid DeskId { get; private set; }
    // public DateTime StartTime { get; private set; }
    // public DateTime EndTime { get; private set; }

    public TimeRange Time {get; private set; }
    public ReservationStatus Status { get; set; }

    private Reservation() { }

    public Reservation(Guid id, Guid userId, Guid deskId, TimeRange timeRange, ReservationStatus status)
    {
        Id = id;
        UserId = userId;
        DeskId = deskId;
        Time = timeRange;
        Status = status;
    }
}