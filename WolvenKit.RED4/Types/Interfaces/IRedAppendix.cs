using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types;

public enum ProcessTime
{
    OnAccess,
    OnFileProcessing
}

public interface IRedAppendix
{
    public void Read(Red4Reader reader, uint size);
    public void Write(Red4Writer writer);

    public virtual ProcessTime GetProcessTime() => ProcessTime.OnAccess;

    public virtual void LoadData(RedBaseClass cls)
    {

    }

    public virtual void StoreData()
    {

    }
}
