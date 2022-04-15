using MediatR;
using Movies.API.Events;

namespace Movies.API.EventHandler;

public class MovieCreatedEventEmailHandler : INotificationHandler<MovieCreatedEvent>
{
    private readonly ILogger<MovieCreatedEventEmailHandler> _logger;

    public MovieCreatedEventEmailHandler(ILogger<MovieCreatedEventEmailHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(MovieCreatedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation($"Email has been sent : Movie ID={notification.Id}, Movie Title={notification.Title}");

        return Task.CompletedTask;
    }
}