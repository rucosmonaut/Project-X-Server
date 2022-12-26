using System.Collections.Generic;
using RAGE;
using RAGE.Ui;

namespace Client
{
    public class TickEvent : Events.Script
    {
        public TickEvent()
        {
           RAGE.Events.Tick = Tick; 
        }

        private void Tick(List<RAGE.Events.TickNametagData> nametags)
        {
            KeyManager.KeyBind(KeyManager.KeyDigit3, () =>
            {
                Chat.Output($"~g~3 pressed");
                Weapon.ShowComponentMenu();
            });


            KeyManager.KeyBind(KeyManager.KeyDigit4, () =>
            {
                Chat.Output($"~g~4 pressed");
                Weapon.GetRevolver();
            });

            KeyManager.KeyBind(KeyManager.KeyLctrl, () =>
            {
                Chat.Output("Key Bind Work");
            });

            KeyManager.KeyBind(KeyManager.KeyMouse, () => // ~
            {
                Cursor.Visible = !Cursor.Visible;               
            }); 

        }

    }


}