using Client.HashCodes;
using RAGE;
using RAGE.Elements;
using RAGE.NUI;
using RAGE.Ui;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Client
{
    public class Weapon : Events.Script
    {
        public static bool WeaponComponentMenuVisible = false;
        private static readonly RAGE.NUI.UIMenu UI = new RAGE.NUI.UIMenu("Компоненты для оружия", "Выберите необходимые компоненты для вашего оружия");
        private static MenuPool menuPool = new MenuPool();
        public Weapon()
        {
            Chat.Output($"Weapon script loaded");
            Events.Add("SetWeaponComponent", OnSetWeaponComponent);
            Events.Add("ShowComponentMenu", OnShowComponentMenu);
            Events.Tick += Tick;
            foreach (var item in WeaponsComponentsHash.HeavyRevolverMkIIComponents)
            {
                UIMenuItem menuItem = new UIMenuItem(item.Key)
                {
                    ItemData = item.Value
                };
                menuItem.Activated += MenuItem_Activated;
                UI.AddItem(menuItem);
            }
            menuPool.Add(UI);
            Input.Bind(0x33, false, ShowComponentMenu);
        }


        private void Tick(List<Events.TickNametagData> nametags)
        {
            menuPool.ProcessMenus();
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

            UI.Visible = UI.Visible != true;
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