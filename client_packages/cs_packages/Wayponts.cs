using RAGE;

namespace RolePlayClient
{
    public class Wayponts : Events.Script
    {
        public Wayponts()
        {
            Events.OnPlayerCreateWaypoint += OnWaypointCreated;
        }

        public void OnWaypointCreated(Vector3 position)
        {
            Chat.Output($"You have just created a waypoint with coords: {position}");
        }
    }
}
