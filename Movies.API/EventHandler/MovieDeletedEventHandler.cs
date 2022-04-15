using MediatR;
using Movies.API.Events;

namespace Movies.API.EventHandler
{
    public class MovieDeletedEventHandler : INotificationHandler<MovieDeletedEvent>
    {
        private readonly ILogger<MovieDeletedEventHandler> _logger;

        public MovieDeletedEventHandler(ILogger<MovieDeletedEventHandler> logger)
        {
            _logger = logger;
        }

        public Task Handle(MovieDeletedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Movie has been deleted : Movie ID={notification.Id}, Movie Title={notification.Title}");

            return Task.CompletedTask;
        }
    }
}
