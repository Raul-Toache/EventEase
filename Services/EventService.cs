using EventEase.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventEase.Services
{
    public class EventService : IEventService
    {
        private readonly List<Event> _events;

        public EventService()
        {
            var baseEvents = new[]
            {
                new Event { Id = 1, Name = "Corporate Mixer", Date = DateTime.UtcNow.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 2, Name = "Charity Gala", Date = DateTime.UtcNow.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 3, Name = "Tech Conference", Date = DateTime.UtcNow.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 5, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 6, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 7, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 8, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 9, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 10, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 11, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 12, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 13, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 14, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 15, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 16, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 17, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 18, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 19, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 20, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 21, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 22, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 23, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 24, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 25, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 26, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 27, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 28, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 29, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 30, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 31, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 32, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 33, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 34, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 35, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 36, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 37, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 38, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 39, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 40, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 41, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 42, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 43, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 44, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 45, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 46, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 47, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 48, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 49, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 50, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 51, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 52, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 53, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 54, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 55, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 56, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 57, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 58, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 59, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 60, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 61, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 62, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 63, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 64, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 65, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 66, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 67, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 68, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 69, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 70, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 71, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 72, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 73, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 74, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 75, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 76, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 77, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 78, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 79, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 80, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 81, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 82, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 83, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 84, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 85, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 86, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 87, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 88, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 89, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 90, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 91, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 92, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 93, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 94, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 95, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 96, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 97, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" },
                new Event { Id = 98, Name = "Corporate Mixer", Date = DateTime.Now.AddDays(10), Location = "Convention Center", Description = "A networking mixer.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Mix" },
                new Event { Id = 99, Name = "Charity Gala", Date = DateTime.Now.AddDays(30), Location = "Grand Hotel", Description = "Fundraising gala.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Gala" },
                new Event { Id = 100, Name = "Tech Conference", Date = DateTime.Now.AddDays(60), Location = "Tech Park", Description = "Talks and workshops.", ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Tech" }
                
            };

            _events = new List<Event>(baseEvents);

            for (var i = 4; i <= 100; i++)
            {
                var template = baseEvents[(i - 1) % baseEvents.Length];
                _events.Add(new Event
                {
                    Id = i,
                    Name = template.Name,
                    Date = template.Date.AddDays(2 * i),
                    Location = template.Location,
                    Description = template.Description,
                    ImageUrl = template.ImageUrl
                });
            }
        }

        // public EventService()
        // {
        //     // Add a static set of non-generated events up to 100 entries.
        //     for (int i = 4; i <= 100; i++)
        //     {
        //         _events.Add(new Event
        //         {
        
        // };

        // public EventService()
        // {
        //     // Add a static set of non-generated events up to 100 entries.
        //     for (int i = 4; i <= 100; i++)
        //     {
        //         _events.Add(new Event
        //         {
        //             Id = i,
        //             Name = $"Event #{i}",
        //             Date = DateTime.Now.AddDays(i * 2),
        //             Location = $"Location {i}",
        //             Description = $"Static event entry #{i} for demo use.",
        //             ImageUrl = "https://via.placeholder.com/160x160/0d6efd/ffffff?text=Event"
        //         });
        //     }
        // }

        public Task<List<Event>> GetEventsAsync(int count = 0)
        {
            if (count > 0 && count < _events.Count)
            {
                return Task.FromResult(_events.Take(count).ToList());
            }

            return Task.FromResult(new List<Event>(_events));
        }

        public Task<Event?> GetEventByIdAsync(int id) => Task.FromResult(_events.FirstOrDefault(e => e.Id == id));
    }
}
