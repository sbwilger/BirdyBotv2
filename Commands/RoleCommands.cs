using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using DSharpPlus.Interactivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Serana Wilger
/// 06/18/2020
/// RoleCommands.cs
/// 
/// This class defines the commands which allow the users to manage their roles.
/// </summary>

namespace BirdyBotv2.Commands
{
    class RoleCommands : BaseCommandModule
    {
        //work in progress
        [Command("pronouns")]
        [Description("Allows users to set their pronouns in the server")]
        public async Task SetPronouns(CommandContext ctx)
        {
            DiscordEmbedBuilder pronounEmbed = new DiscordEmbedBuilder
            {
                Title = "Set Your Pronouns",
                Color = DiscordColor.Cyan
            };

            //adds fields to the embed
            pronounEmbed.AddField(":one: :", "She / Her");
            pronounEmbed.AddField(":two: :", "He / Him");
            pronounEmbed.AddField(":three: :", "They / Them");
            pronounEmbed.AddField(":four: :", "He / She / They");
            pronounEmbed.AddField(":five: :", "They / He");
            pronounEmbed.AddField(":six: :", "They / She");
            pronounEmbed.AddField(":seven: :", "Call Me Whatever (No Preference)");
            pronounEmbed.AddField(":eight: :", "Call Me By My Name (No Nouns)");

            DiscordMessage pronounMessage = await ctx.Channel.SendMessageAsync(embed: pronounEmbed).ConfigureAwait(false);

            DiscordEmoji one = DiscordEmoji.FromName(ctx.Client, ":one:");
            DiscordEmoji two = DiscordEmoji.FromName(ctx.Client, ":two:");
            DiscordEmoji three = DiscordEmoji.FromName(ctx.Client, ":three:");
            DiscordEmoji four = DiscordEmoji.FromName(ctx.Client, ":four:");
            DiscordEmoji five = DiscordEmoji.FromName(ctx.Client, ":five:");
            DiscordEmoji six = DiscordEmoji.FromName(ctx.Client, ":six:");
            DiscordEmoji seven = DiscordEmoji.FromName(ctx.Client, ":seven:");
            DiscordEmoji eight = DiscordEmoji.FromName(ctx.Client, ":eight:");

            DiscordRole sheHer;
            DiscordRole heHim;
            DiscordRole theyThem;
            DiscordRole heSheThey;
            DiscordRole theyHe;
            DiscordRole theyShe;
            DiscordRole callMeWhatever;
            DiscordRole noNouns;

            if (ctx.Guild.Name == "The Cyan Blades")
            {
                sheHer = ctx.Guild.GetRole(724251338375954432);
                heHim = ctx.Guild.GetRole(724251720326053928);
                theyThem = ctx.Guild.GetRole(724251807274238022);
                heSheThey = ctx.Guild.GetRole(724251911858946049);
                theyHe = ctx.Guild.GetRole(724252024903827508);
                theyShe = ctx.Guild.GetRole(724252107066048615);
                callMeWhatever = ctx.Guild.GetRole(724252197990432862);
                noNouns = ctx.Guild.GetRole(724252313681920061);
            }
            else
            {
                sheHer = ctx.Guild.GetRole(749851401517006929);
                heHim = ctx.Guild.GetRole(749752249697304576);
                theyThem = ctx.Guild.GetRole(749854191878668379);
                heSheThey = ctx.Guild.GetRole(749854247209926726);
                theyHe = ctx.Guild.GetRole(749854332610150480);
                theyShe = ctx.Guild.GetRole(749855812016537651);
                callMeWhatever = ctx.Guild.GetRole(749856035745038406);
                noNouns = ctx.Guild.GetRole(749854428961439755);
            }

            await pronounMessage.CreateReactionAsync(one).ConfigureAwait(false);
            await pronounMessage.CreateReactionAsync(two).ConfigureAwait(false);
            await pronounMessage.CreateReactionAsync(three).ConfigureAwait(false);
            await pronounMessage.CreateReactionAsync(four).ConfigureAwait(false);
            await pronounMessage.CreateReactionAsync(five).ConfigureAwait(false);
            await pronounMessage.CreateReactionAsync(six).ConfigureAwait(false);
            await pronounMessage.CreateReactionAsync(seven).ConfigureAwait(false);
            await pronounMessage.CreateReactionAsync(eight).ConfigureAwait(false);

            DiscordMessage pingReminder = await ctx.Channel.SendMessageAsync("If your preferred pronouns are missing, please feel free to tag Serana to add them.").ConfigureAwait(false);

            InteractivityExtension interactivity = ctx.Client.GetInteractivity();

            var reactionResult = await interactivity.WaitForReactionAsync(
                x => x.Message == pronounMessage &&
                x.User == ctx.User &&
                (x.Emoji == one || x.Emoji == two || x.Emoji == three || x.Emoji == four || x.Emoji == five || x.Emoji == six || x.Emoji == seven || x.Emoji == eight)).ConfigureAwait(false);

            if (reactionResult.Result.Emoji == one)
            {
                if (ctx.Member.Roles.Contains(sheHer))
                {
                    await ctx.Member.RevokeRoleAsync(sheHer).ConfigureAwait(false);
                }
                else
                {
                    await ctx.Member.GrantRoleAsync(sheHer).ConfigureAwait(false);
                }
            }
            else if (reactionResult.Result.Emoji == two)
            {
                if (ctx.Member.Roles.Contains(heHim))
                {
                    await ctx.Member.RevokeRoleAsync(heHim).ConfigureAwait(false);
                }
                else
                {
                    await ctx.Member.GrantRoleAsync(heHim).ConfigureAwait(false);
                }
            }
            else if (reactionResult.Result.Emoji == three)
            {
                if (ctx.Member.Roles.Contains(theyThem))
                {
                    await ctx.Member.RevokeRoleAsync(theyThem).ConfigureAwait(false);
                }
                else
                {
                    await ctx.Member.GrantRoleAsync(theyThem).ConfigureAwait(false);
                }
            }
            else if (reactionResult.Result.Emoji == four)
            {
                if (ctx.Member.Roles.Contains(heSheThey))
                {
                    await ctx.Member.RevokeRoleAsync(heSheThey).ConfigureAwait(false);
                }
                else
                {
                    await ctx.Member.GrantRoleAsync(heSheThey).ConfigureAwait(false);
                }
            }
            else if(reactionResult.Result.Emoji == five)
            {
                if (ctx.Member.Roles.Contains(theyHe))
                {
                    await ctx.Member.RevokeRoleAsync(theyHe).ConfigureAwait(false);
                }
                else
                {
                    await ctx.Member.GrantRoleAsync(theyHe).ConfigureAwait(false);
                }
            }
            else if(reactionResult.Result.Emoji == six)
            {
                if (ctx.Member.Roles.Contains(theyShe))
                {
                    await ctx.Member.RevokeRoleAsync(theyShe).ConfigureAwait(false);
                }
                else
                {
                    await ctx.Member.GrantRoleAsync(theyShe).ConfigureAwait(false);
                }
            }
            else if(reactionResult.Result.Emoji == seven)
            {
                if (ctx.Member.Roles.Contains(callMeWhatever))
                {
                    await ctx.Member.RevokeRoleAsync(callMeWhatever).ConfigureAwait(false);
                }
                else
                {
                    await ctx.Member.GrantRoleAsync(callMeWhatever).ConfigureAwait(false);
                }
            }
            else if(reactionResult.Result.Emoji == eight)
            {
                if (ctx.Member.Roles.Contains(noNouns))
                {
                    await ctx.Member.RevokeRoleAsync(noNouns).ConfigureAwait(false);
                }
                else
                {
                    await ctx.Member.GrantRoleAsync(noNouns).ConfigureAwait(false);
                }
            }

            await pronounMessage.DeleteAsync().ConfigureAwait(false);
            await pingReminder.DeleteAsync().ConfigureAwait(false);
        }

        [Command("optin")]
        [Description("Allows users to opt in to channels")]
        public async Task OptIn(CommandContext ctx)
        {
            DiscordEmbedBuilder optinEmbed = new DiscordEmbedBuilder
            {
                Title = "Which Channel would you like to opt in to?",
                Color = DiscordColor.Cyan
            };

            //adds fields to the embed
            optinEmbed.AddField(":one: :", "CW/NSFW");
            optinEmbed.AddField(":two: :", "Gay for Girls");
            optinEmbed.AddField(":three: :", "Gay for Boys");
            optinEmbed.AddField(":four: :", "Trans");
            optinEmbed.AddField(":five: :", "Bi and Pan");
            optinEmbed.AddField(":six: :", "Aro");
            optinEmbed.AddField(":seven: :", "Ace");

            DiscordMessage optinMessage = await ctx.Channel.SendMessageAsync(embed: optinEmbed).ConfigureAwait(false);

            DiscordEmoji one = DiscordEmoji.FromName(ctx.Client, ":one:");
            DiscordEmoji two = DiscordEmoji.FromName(ctx.Client, ":two:");
            DiscordEmoji three = DiscordEmoji.FromName(ctx.Client, ":three:");
            DiscordEmoji four = DiscordEmoji.FromName(ctx.Client, ":four:");
            DiscordEmoji five = DiscordEmoji.FromName(ctx.Client, ":five:");
            DiscordEmoji six = DiscordEmoji.FromName(ctx.Client, ":six:");
            DiscordEmoji seven = DiscordEmoji.FromName(ctx.Client, ":seven:");

            DiscordRole cwNSFW = ctx.Guild.GetRole(749746783898304525);
            DiscordRole gfg = ctx.Guild.GetRole(749752249697304576);
            DiscordRole gfb = ctx.Guild.GetRole(749752221515644938);
            DiscordRole trans = ctx.Guild.GetRole(749752312595087429);
            DiscordRole biPan = ctx.Guild.GetRole(749752256836141088);
            DiscordRole aro = ctx.Guild.GetRole(749752307826032660);
            DiscordRole ace = ctx.Guild.GetRole(749752669563912252);

            await optinMessage.CreateReactionAsync(one).ConfigureAwait(false);
            await optinMessage.CreateReactionAsync(two).ConfigureAwait(false);
            await optinMessage.CreateReactionAsync(three).ConfigureAwait(false);
            await optinMessage.CreateReactionAsync(four).ConfigureAwait(false);
            await optinMessage.CreateReactionAsync(five).ConfigureAwait(false);
            await optinMessage.CreateReactionAsync(six).ConfigureAwait(false);
            await optinMessage.CreateReactionAsync(seven).ConfigureAwait(false);

            InteractivityExtension interactivity = ctx.Client.GetInteractivity();

            var reactionResult = await interactivity.WaitForReactionAsync(
                x => x.Message == optinMessage &&
                x.User == ctx.User &&
                (x.Emoji == one || x.Emoji == two || x.Emoji == three || x.Emoji == four || x.Emoji == five || x.Emoji == six || x.Emoji == seven)).ConfigureAwait(false);

            if (reactionResult.Result.Emoji == one)
            {
                if (ctx.Member.Roles.Contains(cwNSFW))
                {
                    await ctx.Member.RevokeRoleAsync(cwNSFW).ConfigureAwait(false);
                }
                else
                {
                    await ctx.Member.GrantRoleAsync(cwNSFW).ConfigureAwait(false);
                }
            }
            else if (reactionResult.Result.Emoji == two)
            {
                if (ctx.Member.Roles.Contains(gfg))
                {
                    await ctx.Member.RevokeRoleAsync(gfg).ConfigureAwait(false);
                }
                else
                {
                    await ctx.Member.GrantRoleAsync(gfg).ConfigureAwait(false);
                }
            }
            else if (reactionResult.Result.Emoji == three)
            {
                if (ctx.Member.Roles.Contains(gfb))
                {
                    await ctx.Member.RevokeRoleAsync(gfb).ConfigureAwait(false);
                }
                else
                {
                    await ctx.Member.GrantRoleAsync(gfb).ConfigureAwait(false);
                }
            }
            else if (reactionResult.Result.Emoji == four)
            {
                if (ctx.Member.Roles.Contains(trans))
                {
                    await ctx.Member.RevokeRoleAsync(trans).ConfigureAwait(false);
                }
                else
                {
                    await ctx.Member.GrantRoleAsync(trans).ConfigureAwait(false);
                }
            }
            else if (reactionResult.Result.Emoji == five)
            {
                if (ctx.Member.Roles.Contains(biPan))
                {
                    await ctx.Member.RevokeRoleAsync(biPan).ConfigureAwait(false);
                }
                else
                {
                    await ctx.Member.GrantRoleAsync(biPan).ConfigureAwait(false);
                }
            }
            else if (reactionResult.Result.Emoji == six)
            {
                if (ctx.Member.Roles.Contains(aro))
                {
                    await ctx.Member.RevokeRoleAsync(aro).ConfigureAwait(false);
                }
                else
                {
                    await ctx.Member.GrantRoleAsync(aro).ConfigureAwait(false);
                }
            }
            else if (reactionResult.Result.Emoji == seven)
            {
                if (ctx.Member.Roles.Contains(ace))
                {
                    await ctx.Member.RevokeRoleAsync(ace).ConfigureAwait(false);
                }
                else
                {
                    await ctx.Member.GrantRoleAsync(ace).ConfigureAwait(false);
                }
            }

            await optinMessage.DeleteAsync().ConfigureAwait(false);
        }

        [Command("supportStreamers")]
        [Description("Toggles the stream supporter role, which notifies the user when a supported streamer goes live")]
        public async Task SupportStreamers(CommandContext ctx)
        {
            DiscordEmbedBuilder supportEmbed = new DiscordEmbedBuilder
            {
                Title = "Support streamers?",
                Color = DiscordColor.Cyan
            };

            DiscordMessage supportMessage = await ctx.Channel.SendMessageAsync(embed: supportEmbed).ConfigureAwait(false);

            DiscordEmoji thumbsUpEmoji = DiscordEmoji.FromName(ctx.Client, ":+1:");
            DiscordEmoji thumbsDownEmoji = DiscordEmoji.FromName(ctx.Client, ":-1:");

            await supportMessage.CreateReactionAsync(thumbsUpEmoji).ConfigureAwait(false);
            await supportMessage.CreateReactionAsync(thumbsDownEmoji).ConfigureAwait(false);

            InteractivityExtension interactivity = ctx.Client.GetInteractivity();

            var reactionResult = await interactivity.WaitForReactionAsync(
                x => x.Message == supportMessage &&
                x.User == ctx.User &&
                (x.Emoji == thumbsUpEmoji || x.Emoji == thumbsDownEmoji)).ConfigureAwait(false);

            DiscordRole role = ctx.Guild.GetRole(676505924520771595);

            if (reactionResult.Result.Emoji == thumbsUpEmoji)
            {
                await ctx.Member.GrantRoleAsync(role).ConfigureAwait(false);
            }
            else if(reactionResult.Result.Emoji == thumbsDownEmoji)
            {
                await ctx.Member.RevokeRoleAsync(role).ConfigureAwait(false);
            }
            else
            {
                //Something went wrong
            }

            await supportMessage.DeleteAsync().ConfigureAwait(false);
        }
    }
}
