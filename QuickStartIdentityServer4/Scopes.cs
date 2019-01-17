using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickStartIdentityServer4
{
    public class Scopes
    {
        public static List<Scope> GetScops()
        {
            return new List<Scope>
            {
                    new Scope()
                    {
                        Name= "myAPI",
                        Description="This is test API"
                    }
            };
        }
    }
}
