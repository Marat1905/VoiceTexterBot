using VoiceTexterBot.BotConsole.Models;

namespace VoiceTexterBot.BotConsole.Services
{
    public interface IStorage
    {
        /// <summary>
        /// Получение сессии пользователя по идентификатору
        /// </summary>
        Session GetSession(long chatId);
    }
}
