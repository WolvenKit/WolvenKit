namespace WolvenKit.App.Services;

public interface IInstanceSettings
{
    string AppDataPath { get; set; }

    void Load(string instanceSettingsFile, string[] executableArguments);
}
