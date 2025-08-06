using OneOf;
using OneOf.Types;

namespace NadekoBot.Modules.Waifus.Waifus_Hubbies;

public readonly struct ErrSelfNotAllowed;

public readonly struct ErrNoActionsLeft;

public readonly struct ErrWaifuNotFound;

[GenerateOneOf]
public sealed partial class ImproveMoodResult : OneOfBase<
    ErrSelfNotAllowed,
    ErrNoActionsLeft,
    ErrWaifuNotFound,
    Unknown,
    Success
>;

public enum WaifuOrHubby
{
    Waifu,
    Hubby
}

public sealed class Waifu
{
    public string Name { get; set; }
    public string Avatar { get; set; }
    
    public float Secret { get; set; }
}

public sealed class WaifuInfo
{
    public required string Name { get; init; }
    public required string Avatar { get; init; }
    
    public required float Mood { get; init; }
    public required float Hunger { get; init; }

    public required int FanCount { get; init; }
    public required long FanValue { get; init; }
    
    public required float WaifuPercentFee { get; init; }
    public required long ManagerFixedFee { get; init; }

    public required long TotalProduced { get; init; }
}

public class WnHService
{
    private async Task Produce(WaifuInfo wi)
    {
    }

    public async Task<ImproveMoodResult> ImproveMood(ulong userId, ulong waifuId, WaifuAction action)
    {
        return new Success();
    }

    public async Task<WaifuInfo> GetWaifuInfo(ulong userId)
    {
        return new WaifuInfo()
        {
        };
    }

    
    private async Task OptInInternalAsync(ulong userId, string name)
    public async Task OptInAsync(ulong userId, string name)
    {
    }
}

