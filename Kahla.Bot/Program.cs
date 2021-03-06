﻿using Kahla.Bot.Bots;
using Kahla.SDK.Abstract;
using System.Linq;
using System.Threading.Tasks;

namespace Kahla.Bot
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            await CreateBotBuilder()
#warning select Bot
                .Build<EmptyBot>()
                .Run(
                    enableCommander: args.FirstOrDefault() != "as-service",
                    autoReconnectMax: 10);
        }

        public static BotBuilder CreateBotBuilder()
        {
            return new BotBuilder()
                .UseStartUp<StartUp>();
        }
    }
}
