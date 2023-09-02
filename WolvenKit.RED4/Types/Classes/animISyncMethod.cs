
namespace WolvenKit.RED4.Types
{
	public abstract partial class animISyncMethod : ISerializable
	{
		public animISyncMethod()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
