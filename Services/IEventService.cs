using EventEase.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventEase.Services
{
    public interface IEventService
    {
        Task<List<Event>> GetEventsAsync(int count = 0);
        Task<Event?> GetEventByIdAsync(int id);
    }
}
