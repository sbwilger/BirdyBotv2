using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Serana Wilger
/// 06/18/2020
/// FunCommands.cs
/// 
/// This class defines a bunch of commands which return fun gifs when used.
/// </summary>

namespace BirdyBotv2.Commands
{
    public class FunCommands : BaseCommandModule
    {

        [Command("australia")]
        [Description("Gif of a guy smashing through a wall")]
        public async Task Australia(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://cdn.discordapp.com/attachments/517738784620806154/676500826096926722/d8enda9pmicuvq4kmsgh.gif").ConfigureAwait(false);
        }

        [Command("babyYoda")]
        [Description("Gif of baby yoda flying")]
        public async Task BabyYoda(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://tenor.com/view/baby-yoda-baby-yoda-happy-laughing-smile-happy-gif-16061896").ConfigureAwait(false);
        }

        [Command("badidea")]
        [Description("Gif of the Heavy from TF2 having a very bad idea")]
        public async Task BadIdea(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://66.media.tumblr.com/64a6c5f3d6de065bd327760c5128b9ba/tumblr_ox1cd9K4fo1tgg9cbo1_400.gif").ConfigureAwait(false);
        }

        [Command("begoneFit")]
        [Description("Gif of a Honda Fit being left in the dust")]
        public async Task BegoneFit(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://gfycat.com/indelibleindolentcowbird").ConfigureAwait(false);
        }

        [Command("breadcrumbs")]
        [Description("Gif of a duck losing its mind over breadcrumbs")]
        public async Task Breadcrumbs(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://cdn.discordapp.com/attachments/560547675817246780/676875319915053106/unknown.gif").ConfigureAwait(false);
        }

        [Command("cleric")]
        [Description("Gif of a D&D player (Laura Bailey) realizing that they're the cleric in the party")]
        public async Task Cleric(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://media.giphy.com/media/xUOwGjrbwK3Q2y6n60/giphy.gif").ConfigureAwait(false);
        }

        [Command("cliff")]
        [Description("Gif of the Heavy from TF2 driving off of a cliff")]
        public async Task Cliff(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://cdn.discordapp.com/attachments/517738784620806154/676500069708464178/BouncyEcstaticBelugawhale-max-1mb.gif").ConfigureAwait(false);
        }

        [Command("covid")]
        [Description("Welcome to the end times")]
        public async Task Covid(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://media.giphy.com/media/5t3NtJ06GU5LnEouf1/giphy.gif").ConfigureAwait(false);
        }

        [Command("damage")]
        [Description("Gif to respond to someone dealing a lot of damage with")]
        public async Task Damage(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://tenor.com/view/damage-thats-alot-of-damage-jon-tron-gif-13054497").ConfigureAwait(false);
        }

        [Command("devilZ")]
        [Description("Gif of the Devil Z from Wangan Midnight")]
        public async Task DevilZ(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://gfycat.com/pastspotlessbunting-wangan-midnight").ConfigureAwait(false);
        }

        [Command("done")]
        [Description("Gif of the medic declaring his job complete")]
        public async Task Done(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://cdn.discordapp.com/attachments/517738784620806154/676499329145503784/1520511727_job-done.gif").ConfigureAwait(false);
        }

        [Command("drink")]
        [Description("Gif from the good place about denying problems")]
        public async Task Drink(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://tenor.com/view/ignore-problems-lets-drink-drink-heavily-lets-do-it-lets-go-gif-11000409").ConfigureAwait(false);
        }

        [Command("fun")]
        [Description("Gif of Talesin Jaffe from critical role")]
        public async Task Fun(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://media.giphy.com/media/3ohhwHFgLxJv3HasdG/giphy.gif").ConfigureAwait(false);
        }

        [Command("hockey")]
        [Description("Let's do that hockey! (my loving girlfriend Erika added this one)")]
        public async Task Hockey(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://media.tenor.com/images/ae1409d6b9fcd78db67e6ce2ce635f76/tenor.gif").ConfigureAwait(false);
        }

        [Command("icecream")]
        [Description("Gif of a corgi eating ice cream")]
        public async Task IceCream(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://media.giphy.com/media/xT9DPzgJqzHkSgh572/giphy.gif").ConfigureAwait(false);
        }

        [Command("impressed")]
        [Description("Gif of Talesin Jaffe about to be impressed and taking it back")]
        public async Task Impressed(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://media.giphy.com/media/3ohc1cWo255fqJFGV2/giphy.gif").ConfigureAwait(false);
        }

        [Command("interesting")]
        [Description("Gif of a person reading something interesting")]
        public async Task Interesting(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://media.tenor.com/images/d5a8fc2edb196b38c3adc45d1c93f995/tenor.gif").ConfigureAwait(false);
        }

        [Command("knife")]
        [Description("Gif of Rosa from Brooklyn99 with a knife")]
        public async Task Knife(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://media.giphy.com/media/3o85xDXrHgIpXtKj60/giphy.gif").ConfigureAwait(false);
        }

        [Command("love")]
        [Description("Gif for showering someone with all of the love and affection")]
        public async Task Love(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://cdn.discordapp.com/attachments/650801324107235418/677988796406431901/8544265941277400730.gif").ConfigureAwait(false);
        }

        [Command("lovebear")]
        [Description("Gif for showering someone with all of the love and affection")]
        public async Task LoveBear(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://cdn.discordapp.com/attachments/547466846551670795/734602395182432437/unknown.gif").ConfigureAwait(false);
        }

        [Command("miata")]
        [Description("Gif of a miata emanating an aura")]
        public async Task Miata(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://tenor.com/5M0b.gif").ConfigureAwait(false);
        }

        [Command("miataRace")]
        [Description("Gif of miatas racing")]
        public async Task MiataRace(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://giphy.com/gifs/sNtLk0HCjWDRK").ConfigureAwait(false);
        }

        [Command("mindBlown")]
        [Description("Gif of the spy's head exploding")]
        public async Task MindBlown(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://media.discordapp.net/attachments/517738784620806154/676500255126061056/f5a.gif").ConfigureAwait(false);
        }

        [Command("missYou")]
        [Description("Yearn o'clock")]
        public async Task MissYou(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://media.tenor.com/images/319ccf6cf2acc571677cd3626fe2897a/tenor.gif").ConfigureAwait(false);
        }

        [Command("noice")]
        [Description("Noice")]
        public async Task Noice(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://giphy.com/gifs/yJFeycRK2DB4c").ConfigureAwait(false);
        }

        [Command("ohGodWhat")]
        [Description("Gif of a miata looking surprised")]
        public async Task OhGodWhat(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://gfycat.com/unlawfulunhealthybass").ConfigureAwait(false);
        }

        [Command("pass")]
        [Description("Gif of the Devil Z passing a Supra")]
        public async Task Pass(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://gfycat.com/achingkaleidoscopicdogwoodtwigborer").ConfigureAwait(false);
        }

        [Command("ptfo")]
        [Description("Gif of the objective being stolen")]
        public async Task PTFO(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://66.media.tumblr.com/d42c814c9cc4d2445e169ee78eec61df/tumblr_o81k3xbyaN1r8lde5o1_500.gif").ConfigureAwait(false);
        }

        [Command("purge")]
        [Description("Gif of Rosa from b99 advocating for anarchy")]
        public async Task Purge(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://media.giphy.com/media/nWeZTrDBI75QI/giphy.gif").ConfigureAwait(false);
        }

        [Command("rusted")]
        [Description("Gif #1 for Rusted Crow")]
        public async Task Rusted(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://tenor.com/view/pyro-teamfortress-tf2-teamfortress2-insane-gif-5053750").ConfigureAwait(false);
        }

        [Command("rusted2")]
        [Description("Gif #2 for RustedCrow")]
        public async Task Rusted2(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("http://66.media.tumblr.com/tumblr_m6am5iI52V1qcsioio6_250.gif").ConfigureAwait(false);
        }

        [Command("teamwork")]
        [Description("Gif of TF2 characters working together")]
        public async Task Teamwork(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("http://31.media.tumblr.com/3c133843db5353c9be2f4b528f9c0c4a/tumblr_mwoos5rQ5W1rxucm6o1_400.gif").ConfigureAwait(false);
        }

        [Command("trace")]
        [Description("Gif of Gina from B99 declaring that there is no paper trail")]
        public async Task Trace(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://media.giphy.com/media/cFxwH6xF8dNFm/giphy.gif").ConfigureAwait(false);
        }

        [Command("um")]
        [Description("Gif of Nathan Fillion unsure how to react")]
        public async Task Um(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://media.tenor.com/images/aa228bc7b514e19303a62c999739420c/tenor.gif").ConfigureAwait(false);
        }

        [Command("wilger")]
        [Description("Gif of a Maple leaf saying deal with it")]
        public async Task Wilger(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("https://gph.is/1sFeQP5").ConfigureAwait(false);
        }
    }
}