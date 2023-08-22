
namespace WolvenKit.RED4.Types
{
	public abstract partial class ComDeviceTransition : DefaultTransition
	{
		public ComDeviceTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
