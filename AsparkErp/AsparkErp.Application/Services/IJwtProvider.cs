using AsparkErp.Application.Features.Auth.Login;
using AsparkErp.Domain.Entities;

namespace AsparkErp.Application.Services
{
    public interface IJwtProvider
    {
        Task<LoginCommandResponse> CreateToken(AppUser user);
    }
}
