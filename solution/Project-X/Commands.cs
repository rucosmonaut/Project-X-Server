using GTANetworkAPI;
using Project_X.Services;

namespace Project_X
{
    internal class Commands : Script
    {
        [Command("car")]
        public void CmdCreateCar(Player player, string type, int color1, int color2)
        {
            uint myCarType = NAPI.Util.GetHashKey(type);
            var veh = NAPI.Vehicle.CreateVehicle(myCarType, player.Position.Around(5), 0, color1, color2);
            NAPI.Chat.SendChatMessageToPlayer(player, $"Cкорость Т/C: {(veh.MaxSpeed * 3.6)}");

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
                NAPI.Chat.SendChatMessageToPlayer(player, "~g~Неверный пароль");
        }
    }
}
