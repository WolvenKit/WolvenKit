namespace WolvenKit.RED4.Types;

public interface IRedBufferPointer
{
    public RedBuffer GetValue();
    public void SetValue(RedBuffer instance);
}