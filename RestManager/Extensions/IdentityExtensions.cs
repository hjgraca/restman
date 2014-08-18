using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace Microsoft.AspNet.Identity
{
    // Summary:
    //     Extensions making it easier to get the user name/user id claims off of an
    //     identity
    public static class IdentityExtensions
    {
        //
        // Summary:
        //     Return the restaurantId
        //
        // Parameters:
        //   identity:
        public static string GetRestaurantId(this IIdentity identity)
        {
            return Getvalue(identity, "RestaurantId");
        }

        private static string Getvalue(this IIdentity identity, string type)
        {
            var id = identity as System.Security.Claims.ClaimsIdentity;
            if (id == null)
            {
                return string.Empty;
            }

            var value = id.Claims.FirstOrDefault(x => x.Type == type);

            if (value == null)
            {
                return string.Empty;
            }
            return value.Value.Trim();
        }
    }
}