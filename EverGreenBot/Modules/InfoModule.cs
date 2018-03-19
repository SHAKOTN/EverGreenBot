using System.Threading.Tasks;

using Discord.Commands;
using Discord.WebSocket;
             
namespace EverGreenBot.Modules
{
    public class InfoModule : ModuleBase<SocketCommandContext>
    {
        [Command("say")]
        [Summary("Echo a message")]
        public async Task SayAsync([Remainder] [Summary("The text")] string echo)
        {
            await ReplyAsync(echo);
        }

        [Command("userinfo")]
        [Summary("Returns info about the current user, or the user parameter, if one passed.")]
        [Alias("user", "whois")]
        public async Task UserInfoAsync([Summary("The (optional) user to get info for")] SocketUser user = null)
        {
            var userInfo = user ?? Context.Client.CurrentUser;
            await ReplyAsync($"{userInfo.Username}#{userInfo.Discriminator}");
        }
    }
}
