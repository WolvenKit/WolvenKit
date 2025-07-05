namespace WolvenKit.RED4.Types;

public interface IRedNotifyObjectChanged
{
    public event ObjectChangedEventHandler ObjectChanged;
}