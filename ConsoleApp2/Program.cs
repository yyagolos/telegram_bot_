using System;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace ConsoleApp2
{
    class  Program
    {
        static void Main(string[] args) 
        {
            var client = new TelegramBotClient("6100868509:AAGyj11x-2oTCohw3V4SDxKJ7LtkZK29sEw");
            client.StartReceiving(Update, Error);
            Console.ReadKey();
        }

        async static Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
        {
            var message = update.Message;
            if (message.Text != null)
            {
                if (message.Text.ToLower().Contains("здарова"))
                {
                   await botClient.SendTextMessageAsync(message.Chat.Id,"Здоровей видали");
                    return;

                }
            }
            if (message.Photo != null)
            {
                await botClient.SendTextMessageAsync(message.Chat.Id, "Нормально. лучше отправь фото документом");
                return;
            }
        }

        private static Task Error(ITelegramBotClient client, Exception exception, CancellationToken token)
        {
            throw new NotImplementedException();
        }
    }

}

