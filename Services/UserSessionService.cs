using EventEase.Models;
using System;
using System.Collections.Generic;

namespace EventEase.Services
{
    public class RegisteredEvent
    {
        public int EventId { get; set; }
        public string EventName { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Location { get; set; } = string.Empty;
        public string RegistrantName { get; set; } = string.Empty;
        public string RegistrantEmail { get; set; } = string.Empty;
        public DateTime RegisteredAt { get; set; }
        public bool IsAttended { get; set; }
    }

    public class UserSessionService
    {
        private readonly List<RegisteredEvent> _registrations = new();

        public string UserName { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;

        public bool IsAuthenticated => !string.IsNullOrWhiteSpace(UserName);

        public IReadOnlyList<RegisteredEvent> Registrations => _registrations.AsReadOnly();

        public void SetUser(string userName, string email)
        {
            UserName = userName ?? string.Empty;
            Email = email ?? string.Empty;
        }

        public void AddRegistration(Event @event, EventRegistration registration)
        {
            if (@event == null || registration == null) return;

            _registrations.Add(new RegisteredEvent
            {
                EventId = @event.Id,
                EventName = @event.Name,
                Date = @event.Date,
                Location = @event.Location,
                RegistrantName = registration.Name,
                RegistrantEmail = registration.Email,
                RegisteredAt = DateTime.Now
            });

            SetUser(registration.Name, registration.Email);
        }

        public void SetAttendance(int eventId, bool attended)
        {
            var reg = _registrations.Find(r => r.EventId == eventId);
            if (reg != null)
            {
                reg.IsAttended = attended;
            }
        }

        public void ClearRegistrations() => _registrations.Clear();

        public void ClearSession()
        {
            UserName = string.Empty;
            Email = string.Empty;
            ClearRegistrations();
        }
    }
}