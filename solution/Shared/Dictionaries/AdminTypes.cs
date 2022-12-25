using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Dictionaries
{
    public class Admin
    {
        public enum AdminTypes
        {
            Player,
            Helper,
            SuperHelper,
            ChiefHelper,
            Moderator,
            SuperModerator,
            ChiefModerator,
            Administrator,
            SuperAdministrator,
            Owner
        }

        public readonly Dictionary<AdminTypes, int> AdminLevels = new Dictionary<AdminTypes, int>
        {
            {AdminTypes.Player, 1},
            {AdminTypes.Helper, 2},
            {AdminTypes.SuperHelper, 3},
            {AdminTypes.ChiefHelper, 4},
            {AdminTypes.Moderator, 5},
            {AdminTypes.SuperModerator, 6},
            {AdminTypes.ChiefModerator, 7},
            {AdminTypes.Administrator, 8},
            {AdminTypes.SuperAdministrator, 9},
            {AdminTypes.Owner, 10},
        };
    }
}
