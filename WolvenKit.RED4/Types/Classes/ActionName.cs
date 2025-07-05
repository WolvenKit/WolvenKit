
namespace WolvenKit.RED4.Types
{
	public abstract partial class ActionName : ScriptableDeviceAction
	{
		public ActionName()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
