
namespace WolvenKit.RED4.Types
{
	public abstract partial class DeviceOperationsTrigger : IScriptable
	{
		public DeviceOperationsTrigger()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
