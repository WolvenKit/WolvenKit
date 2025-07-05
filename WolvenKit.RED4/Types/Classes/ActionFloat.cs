
namespace WolvenKit.RED4.Types
{
	public abstract partial class ActionFloat : ScriptableDeviceAction
	{
		public ActionFloat()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
