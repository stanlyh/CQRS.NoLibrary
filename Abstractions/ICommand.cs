namespace CQRS.NoLibrary.Abstractions;

public interface ICommand
{
}


// Handler de comandos
public interface ICommandHandler<TCommand>
    where TCommand : ICommand
{
    Task HandleAsync(TCommand command);
}