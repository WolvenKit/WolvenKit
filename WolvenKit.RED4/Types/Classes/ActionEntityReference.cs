
namespace WolvenKit.RED4.Types
{
	public abstract partial class ActionEntityReference : ScriptableDeviceAction
	{
		public ActionEntityReference()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
