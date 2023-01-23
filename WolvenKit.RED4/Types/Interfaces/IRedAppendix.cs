using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types;

public interface IRedAppendix
{
    //public object Appendix { get; set; }

    public void Read(Red4Reader reader, uint size);
    public void Write(Red4Writer writer);
}