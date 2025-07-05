namespace WolvenKit.RED4.Types;

public interface IDataCollector
{
    public bool CollectData { get; set; }
    public DataCollection DataCollection { get; }
}