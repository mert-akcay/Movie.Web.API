using MediatR;

namespace Movies.API.Events;

public class MovieDeletedEvent : INotification
{
    public int Id { get; set; }
    public string Title { get; set; }
}