namespace DeskHub.Domain.ValueObjects;

public record TimeRange
{
    public DateTimeOffset Start { get; }
    public DateTimeOffset End { get; }

    private TimeRange() { }

    private TimeRange(DateTimeOffset start, DateTimeOffset end)
    {
        Start = start;
        End = end;
    }

    public static TimeRange Create(DateTimeOffset start, DateTimeOffset end)
    {
        if (end <= start)
            throw new ArgumentException("End must be after Start");

        return new TimeRange(start, end);
    }

    public TimeSpan Duration => End - Start;

    public bool Overlaps(TimeRange other)
        => Start < other.End && End > other.Start;
}