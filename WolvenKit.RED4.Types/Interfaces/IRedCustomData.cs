using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types
{
    public interface IRedCustomData
    {
        public void CustomRead(Red4Reader reader, uint size, int zero);
        public void CustomWrite(Red4Writer writer);
    }
}
