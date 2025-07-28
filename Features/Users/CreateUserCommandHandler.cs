using CQRS.NoLibrary.Abstractions;

namespace CQRS.NoLibrary.Features.Users;

public class CreateUserCommandHandler : ICommandHandler<CreateUserCommand>
{
    public async Task HandleAsync(CreateUserCommand command)
    {
        // connect to repository

        // send somewere

        Console.WriteLine("User Created!!!");

        await Task.CompletedTask;
    }
}
