using Client.HashCodes;
using RAGE;
using RAGE.Elements;
using System.Drawing;

namespace Client
{
    public class Weapon : Events.Script
    {
        public static bool WeaponComponentMenuVisible = false;
        private static readonly RAGE.NUI.UIMenu UI = new RAGE.NUI.UIMenu("Компоненты для оружия", "Выберите необходимые компоненты для вашего оружия");

        public Weapon()
        {
            Chat.Output($"Weapon script loaded");
            Events.Add("SetWeaponComponent", OnSetWeaponComponent);
            Events.Add("ShowComponentMenu", OnShowComponentMenu);
        }

        private void OnSetWeaponComponent(object[] args)
        {
            SetWeaponComponent((uint)(int)args[0], (uint)(int)args[1]);
            Chat.Output($"~g~Вы установили компонент");
        }

        private void OnShowComponentMenu(object[] args)
        {
            ShowComponentMenu();
            Chat.Output($"~g~Вы установили компонент");
        }

        public static void ShowComponentMenu()
        {
            Chat.Output($"~g~ShowComponentMenuт");
            
            foreach (var item in WeaponsComponentsHash.HeavyRevolverMkIIComponents)
            {
                RAGE.NUI.UIMenuItem menuItem = new RAGE.NUI.UIMenuItem(item.Key)
                {
                    ItemData = item.Value
                };
                menuItem.Activated += MenuItem_Activated;
                UI.AddItem(menuItem);
            }

            UI.Visible = true;
            UI.Draw();
            //container.Draw();
        }

        private static void MenuItem_Activated(RAGE.NUI.UIMenu sender, RAGE.NUI.UIMenuItem selectedItem)
        {
            uint weaponHash = Player.LocalPlayer.GetSelectedWeapon();
            SetWeaponComponent(weaponHash, (uint)(int)selectedItem.ItemData);
        }

        private static void SetWeaponComponent(uint weaponHash, uint componentHash)
        {
            Player.LocalPlayer.GiveWeaponComponentTo(weaponHash, componentHash);
        }

        public static void GetRevolver()
        {
            RAGE.Game.UIText.Draw("PROJECT-X RP", new Point(300, 400), 10, Color.Red, RAGE.Game.Font.Monospace, true);
            Events.CallRemote("revolver");
        }
    }
}