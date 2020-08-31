using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Serana Wilger
/// 06/18/2020
/// LinkCommands.cs
/// 
/// This class defines the commands which send my links to the server.
/// </summary>

namespace BirdyBotv2.Commands
{
    class LinkCommands : BaseCommandModule
    {
        [Command("github")]
        [Description("Returns the link to the developer's github page")]
        public async Task Github(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://github.com/sbwilger").ConfigureAwait(false);
        }

        [Command("twitch")]
        [Description("Returns the link to the developer's twitch page")]
        public async Task Twitch(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://twitch.tv/birdythemig").ConfigureAwait(false);
        }
    }
}
