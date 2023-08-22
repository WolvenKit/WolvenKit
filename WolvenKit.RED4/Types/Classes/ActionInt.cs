
namespace WolvenKit.RED4.Types
{
	public abstract partial class ActionInt : ScriptableDeviceAction
	{
		public ActionInt()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
