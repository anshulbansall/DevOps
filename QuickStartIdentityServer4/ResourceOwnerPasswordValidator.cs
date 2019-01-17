using ETProject;
using IdentityServer4.Models;
using IdentityServer4.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static IdentityModel.OidcConstants;

namespace QuickStartIdentityServer4
{
    public class ResourceOwnerPasswordValidator : IResourceOwnerPasswordValidator
    {
        public Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
        {
            var context1 = new ETContext();
            var user = context1.Users.Where(u => u.EmailId == context.UserName && u.Password == context.Password).ToList();
            if (user.Count == 0)
            {
                //context.Result = new GrantValidationResult(TokenErrors.InvalidRequest, "User name or password is incorrect");
                context.Result = new GrantValidationResult(TokenRequestErrors.InvalidGrant, "invalid custom credential");
                return Task.FromResult(0);
            }
            else
            {
                context.Result = new GrantValidationResult(context.UserName, "password");
                return Task.FromResult(context);
            }
        }
    }
}
