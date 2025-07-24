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

public class WnHService
{
    public async Task<ImproveMoodResult> ImproveMood(ulong userId, ulong waifuId)
    {
        return new Success();
    }
}