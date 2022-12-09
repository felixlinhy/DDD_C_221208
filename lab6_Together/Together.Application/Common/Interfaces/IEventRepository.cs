using Together.Domain.Entity;

namespace Together.Application.Common.Interfaces;

public interface IEventRepository {
    EventAddResult[] GetAll();
    void AddEvent(EventAddResult e);
}