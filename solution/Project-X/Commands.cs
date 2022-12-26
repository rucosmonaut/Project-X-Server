using GTANetworkAPI;
using Project_X.Services;
using Shared.HashCodes;

namespace Project_X
{
    public class Commands : Script
    {
        [Command("car")]
        public void CreateCar(Player player, string type, int color1, int color2)
        {
            uint myCarType = NAPI.Util.GetHashKey(type);
            var veh = NAPI.Vehicle.CreateVehicle(myCarType, player.Position.Around(5), 0, color1, color2);
            NAPI.Chat.SendChatMessageToPlayer(player, $"Cкорость Т/C: {(veh.MaxSpeed * 3.6)}");
        }

        [Command("weapon")]
        public void GetWeapon(Player player, string type, int ammo)
        {
            uint? hash = WeaponsHash.GetHashCode(type);
            if(hash != null)
            {
                player.GiveWeapon((WeaponHash)hash, ammo);
                NAPI.Chat.SendChatMessageToPlayer(player, $"~g~Вы получили: {type} с патронами: {ammo}");
            }
            else
                NAPI.Chat.SendChatMessageToPlayer(player, "~r~Вы ввели неверное название оружия");  
        }

        [Command("set_weapon_component")]
        public void SetWeaponComponent(Player player, string weapon_type, string component)
        {
            uint? hash_weapon = WeaponsHash.GetHashCode(weapon_type);
            uint? hash_component = WeaponsComponentsHash.GetHashCode(component);
            if (hash_weapon != null && hash_component != null)
                NAPI.ClientEvent.TriggerClientEvent(player, "SetWeaponComponent", (uint)hash_weapon, (uint)hash_component);
            else
                NAPI.Chat.SendChatMessageToPlayer(player, "~r~Вы ввели неверное название оружия");  
        }

        [Command("revolver")]
        public void GiveRevolver(Player player)
        {
            uint? hash_weapon = WeaponsHash.GetHashCode("Revolver");
            uint? hash_component = WeaponsComponentsHash.GetHashCode("RevolverVarmodBoss");

            if (hash_weapon != null)
            {
                player.GiveWeapon((WeaponHash)hash_weapon, 1000);
                NAPI.Chat.SendChatMessageToPlayer(player, $"~g~Вы получили: revolver с патронами");
            }

            if (hash_component != null)
                NAPI.ClientEvent.TriggerClientEvent(player, "SetWeaponComponent", (uint)hash_weapon, (uint)hash_component);
            else
                NAPI.Chat.SendChatMessageToPlayer(player, "~r~Вы ввели неверное название оружия");
        }

        [Command("reg")] 
        public void OnRegistration(Player player, string login, string email, string password)
        {

            bool isCreated = AccountService.CreateAccount(player, login, email, password);

            if (isCreated)
                NAPI.Chat.SendChatMessageToPlayer(player, "~g~Аккаунт успешно зарегестрирован");
            else
                NAPI.Chat.SendChatMessageToPlayer(player, "~r~Аккаунт с таким SocialId уже зарегестрирован," +
                    "\n пожалуйста авторизуйтесь");
        }

        [Command("login")]
        public void OnLogin(Player player, string login, string password)
        {
            bool isLogin = AccountService.LoginAccount(login, password);

            if (isLogin)
                NAPI.Chat.SendChatMessageToPlayer(player, "~g~Вы успешно зашли в аккаунт");
            else
                NAPI.Chat.SendChatMessageToPlayer(player, "~r~Неверный пароль");
        }
    }
}
