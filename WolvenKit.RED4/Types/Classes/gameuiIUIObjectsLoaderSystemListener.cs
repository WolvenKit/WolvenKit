
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameuiIUIObjectsLoaderSystemListener : ISerializable
	{
		public gameuiIUIObjectsLoaderSystemListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
