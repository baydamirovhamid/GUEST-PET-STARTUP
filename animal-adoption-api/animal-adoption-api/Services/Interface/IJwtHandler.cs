using animal.adoption.api.DTO.HelperModels.Jwt;

namespace animal.adoption.api.Services.Interface
{
    public interface IJwtHandler
    {
        JwtResponse CreateToken(JwtCustomClaims model);
    }
}
