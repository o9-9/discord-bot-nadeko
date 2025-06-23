namespace NadekoBot.Modules.Administration.Cleanup;

public interface ICleanupService
{
    Task<KeepResult?> DeleteMissingGuildDataAsync();
}