using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Webmark.Modules.Interfaces;

namespace Webmark.Infrastructure.Identity;

internal sealed class CurrentUserService(IHttpContextAccessor httpContextAccessor) : ICurrentUserService
{
    public string? UserId => httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
}
