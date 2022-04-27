
namespace WolvenKit.RED4.Types
{
	public partial class ISerializable : RedBaseClass
	{
		public ISerializable()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
