using CQRS.NoLibrary.Abstractions;

namespace CQRS.NoLibrary.Features.Users
{
    public record GetUserByIdQuery(int id) : IQuery<UserDto>;


    public class GetUserByIdQueryHandler : IQueryHandler<GetUserByIdQuery, UserDto>
    {
        public async Task<UserDto> HandleAsync(GetUserByIdQuery query)
        {
            //conectar a repository y recuperar el user desde DB
            //return dekl usuario

            return await Task.FromResult(new UserDto() { Id = query.id, Username = "Celeste Kat"});
        }
    }
}
