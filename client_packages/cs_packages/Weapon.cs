using RAGE;

namespace RolePlayClient
{
    public class Weapon : Events.Script
    {
        public Weapon()
        {
            Chat.Output($"Weapon script loaded");
            Events.Add("SetWeaponComponent", SetWeaponComponent);
        }

        private void SetWeaponComponent(object[] args)
        {
            RAGE.Elements.Player.LocalPlayer.GiveWeaponComponentTo((uint)(int)args[0], (uint)(int)args[1]);
            Chat.Output($"~g~Вы установили компонент");
        }
    }
}