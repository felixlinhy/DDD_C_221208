using Together.Application.Common.Interfaces;
using Together.Domain.Entity;

namespace Together.Infrastructure.Persistence;

public class EventMemRepository : IEventRepository
{
    private static readonly List<EventAddResult> _events = new();
    public void AddEvent(EventAddResult e)
    {
        _events.Add(e);
    }
    public EventAddResult[] GetAll()
    {
        return _events.ToArray();
    }
}