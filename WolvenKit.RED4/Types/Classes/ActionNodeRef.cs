
namespace WolvenKit.RED4.Types
{
	public abstract partial class ActionNodeRef : ScriptableDeviceAction
	{
		public ActionNodeRef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
