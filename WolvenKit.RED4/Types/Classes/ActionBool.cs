
namespace WolvenKit.RED4.Types
{
	public abstract partial class ActionBool : ScriptableDeviceAction
	{
		public ActionBool()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
