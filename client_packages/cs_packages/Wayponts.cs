using RAGE;
using System;

namespace RolePlayClient
{
    public class Wayponts : RAGE.Events
    {
        public Wayponts()
        {
            RAGE.Events.OnPlayerCreateWaypoint += OnWaypointCreated;
        }

        public void OnWaypointCreated(Vector3 position)
        {
            RAGE.Chat.Output($"You have just created a waypoint with coords: {position}");
        }
    }
}
