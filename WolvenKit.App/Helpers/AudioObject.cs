namespace WolvenKit.App.Helpers;

public class AudioObject
{
    public AudioObject(string title, byte[] data)
    {
        Title = title;
        Data = data;
    }

    public string Title { get; }
    public byte[] Data { get; }
}
