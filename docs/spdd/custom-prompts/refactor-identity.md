Refactor this solution toward a Clean Architecture structure while preserving all existing functionality.

Current projects:
- Webmark.Web
- Webmark.Infrastructure
- Webmark.Modules

Goals
=====

1. Move ASP.NET Core Identity and EF Core persistence concerns out of Webmark.Web.
2. Ensure business logic in Webmark.Modules does NOT depend on:
   - ASP.NET Core Identity
   - EF Core
   - Microsoft.AspNetCore namespaces
3. Keep the application compiling and functioning exactly as before.
4. Preserve migrations and authentication behavior.

Required Refactor
=================

Move these files from Webmark.Web into Webmark.Infrastructure:

- ApplicationDbContext.cs
- ApplicationUser.cs
- Any Identity-related services/configuration
- Any EF Core configuration classes
- Any DbContext registrations

Target structure:

Webmark.Infrastructure
    /Persistence
        ApplicationDbContext.cs
        Migrations/
        Configurations/

    /Identity
        ApplicationUser.cs
        Identity services

    DependencyInjection.cs

Webmark.Modules
    /Interfaces
    /Features
    /Entities

Webmark.Web
    Program.cs
    UI only

Architecture Rules
==================

- Webmark.Modules must not reference:
  - Microsoft.EntityFrameworkCore
  - Microsoft.AspNetCore.Identity
  - Microsoft.AspNetCore.*

- Webmark.Infrastructure may reference:
  - EF Core
  - ASP.NET Identity
  - external libraries

- Webmark.Web should act only as:
  - composition root
  - UI layer
  - endpoint host

Implementation Requirements
===========================

1. Create extension methods in Infrastructure:

```csharp
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
}
Move DbContext registration into Infrastructure.
Move Identity registration into Infrastructure.
Update Program.cs in Webmark.Web to use:
builder.Services.AddInfrastructure(builder.Configuration);
Ensure ApplicationDbContext remains compatible with Identity:
public class ApplicationDbContext
    : IdentityDbContext<ApplicationUser>
{
}
Preserve migrations:
Ensure migrations still work
Ensure the migrations assembly is configured correctly if necessary
Create abstraction interfaces in Webmark.Modules for any application-facing services currently tied directly to Identity.

Examples:

public interface ICurrentUserService
{
    string? UserId { get; }
}
Implement those interfaces in Infrastructure or Web.
Remove any direct references to ApplicationUser from business/module logic unless absolutely required.
Keep ApplicationUser minimal:
public class ApplicationUser : IdentityUser
{
}
Expected Output

Perform the refactor directly in the codebase.

After refactoring:

show all modified files
explain dependency flow
explain any package reference changes
explain any namespace updates
explain any migration adjustments required

Finally:

verify the solution compiles
verify authentication still works
verify EF migrations still function