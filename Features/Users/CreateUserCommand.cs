using CQRS.NoLibrary.Abstractions;

namespace CQRS.NoLibrary.Features.Users;

public record CreateUserCommand(string Email, string UserName) : ICommand;
