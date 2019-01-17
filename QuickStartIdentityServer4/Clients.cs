using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace QuickStartIdentityServer4
{
    public class Clients
    {
        public static List<Client> GetClient()
        {
            return new List<Client>
            {
                    new Client()
                    {
                        ClientId="Anshul",
                        ClientSecrets=new List<Secret>
                        {
                            new Secret("topsecret".Sha256())
                        },
                        AllowedScopes=
                        {
                            IdentityServerConstants.StandardScopes.OpenId,
                            IdentityServerConstants.StandardScopes.Profile,
                            "myAPI"
                        },
                        AllowedGrantTypes=GrantTypes.ResourceOwnerPassword
                    }
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("myAPI", "Fiver.Security.AuthServer.Api")
            };
        }

        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
            };
        }

        public static List<TestUser> GetUsers()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "1",
                    Username = "james",
                    Password = "password",
                    Claims = new List<Claim>
                    {
                        new Claim("name", "James Bond"),
                        new Claim("website", "https://james.com")
                    }
                },
                new TestUser
                {
                    SubjectId = "2",
                    Username = "spectre",
                    Password = "password",
                    Claims = new List<Claim>
                    {
                        new Claim("name", "Spectre"),
                        new Claim("website", "https://spectre.com")
                    }
                }
            };
        }
    }


}
