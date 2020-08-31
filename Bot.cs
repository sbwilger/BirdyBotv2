using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.EventArgs;
using DSharpPlus.Interactivity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using BirdyBotv2.Commands;

/// <summary>
/// Serana Wilger
/// 06/18/2020
/// Bot.cs
/// 
/// This is the core class of the bot
/// </summary>

namespace BirdyBotv2
{
    public class Bot
    {
        //stores the discord client
        public DiscordClient Client { get; private set; }

        //stores the ability for the bot to interact with thwe users
        public InteractivityExtension Interactivity { get; private set; }
        
        //stores the ability for the user to call commands
        public CommandsNextExtension Commands { get; private set; }

        //constructor
        public async Task RunAsync()
        {
            //creates the string to hold the config file
            string json = string.Empty;

            //reads the config file
            using (FileStream fs = File.OpenRead("config.json"))
            using (StreamReader sr = new StreamReader(fs, new UTF8Encoding(false)))
                json = sr.ReadToEnd();

            //deserializes the json into a struct
            ConfigJson configJson = JsonConvert.DeserializeObject<ConfigJson>(json);

            //configures up the bot's settings 
            DiscordConfiguration config = new DiscordConfiguration
            {
                Token = configJson.Token,
                TokenType = TokenType.Bot,
                AutoReconnect = true
            };

            //initializes the client
            Client = new DiscordClient(config);

            //readies the bot
            Client.Ready += OnClientReady;

            //configures the interactivity settings
            Client.UseInteractivity(new InteractivityConfiguration
            {
                PollBehaviour = DSharpPlus.Interactivity.Enums.PollBehaviour.KeepEmojis
            });

            //configures the command settings
            CommandsNextConfiguration commandsConfig = new CommandsNextConfiguration
            {
                StringPrefixes = new string[] { configJson.Prefix },
                EnableDms = false,
                EnableMentionPrefix = true,
                DmHelp = true
            };

            //activates commands
            Commands = Client.UseCommandsNext(commandsConfig);

            //register all commands for the bot
            Commands.RegisterCommands<FunCommands>();
            Commands.RegisterCommands<LinkCommands>();
            Commands.RegisterCommands<RoleCommands>();

            //connects to the server
            await Client.ConnectAsync().ConfigureAwait(false);

            await Task.Delay(-1);
        }

        //a blank method to frame the point when the bot is ready
        private Task OnClientReady(ReadyEventArgs e)
        {
            return Task.CompletedTask;
        }
    }
}
