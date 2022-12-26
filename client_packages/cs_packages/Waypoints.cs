using RAGE;

namespace RolePlayClient
{
    public class Waypoints : Events.Script
    {
        public Waypoints()
        {
            Chat.Output($"Waypoints script loaded");
            Events.OnPlayerCreateWaypoint += OnWaypointCreated;
        }

        private void OnWaypointCreated(Vector3 position)
        {
            Chat.Output($"You have just created a waypoint with coords: {position}");
            RAGE.Elements.Player.LocalPlayer.Position = position;
        }
    }
}