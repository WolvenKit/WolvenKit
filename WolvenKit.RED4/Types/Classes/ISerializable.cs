
namespace WolvenKit.RED4.Types
{
	public abstract partial class ISerializable : RedBaseClass
	{
		public ISerializable()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
