using MediatR;

namespace Movies.API.Events;

public class MovieCreatedEvent : INotification
{
    public int Id { get; set; }
    public string Title { get; set; }
}