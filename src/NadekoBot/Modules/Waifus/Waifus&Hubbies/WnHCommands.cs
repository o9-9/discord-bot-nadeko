namespace NadekoBot.Modules.Waifus.Waifus_Hubbies;

public class WnHCommands(WnHService svc) : NadekoModule
{
    [Cmd]
    public async Task Waifu([Leftover] IUser? user = null)
    {
        user ??= ctx.User;
    }

    private enum WaifuAction
    {
        Hug,
        Kiss,
        Pat
    }

    private string GetImage(WaifuAction action)
    {
        return "https://test.com";
    }

    private async Task ImproveMood(WaifuAction action, IUser user)
    {
        var res = await svc.ImproveMood(user.Id, user.Id);
        var img = GetImage(action);
        await Response()
            .Embed(_sender.CreateEmbed()
                .WithImageUrl(img))
            .SendAsync();
    }

    [Cmd]
    public Task Hug([Leftover] IUser user)
        => ImproveMood(WaifuAction.Hug, user);

    [Cmd]
    public Task Kiss([Leftover] IUser user)
        => ImproveMood(WaifuAction.Kiss, user);

    [Cmd]
    public Task Pat([Leftover] IUser user)
        => ImproveMood(WaifuAction.Pat, user);

    [Cmd]
    public async Task Gift(string item, [Leftover] IUser user)
    {
    }
}