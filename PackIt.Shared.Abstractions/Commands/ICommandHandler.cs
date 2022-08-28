namespace PackIt.Shared.Abstractions.Commands;

public interface ICommandHandler<in TCommand> where TCommand : class, ICommand
{
    //TODO: Add CancellationToken
    Task HandleAsync(TCommand command);
}