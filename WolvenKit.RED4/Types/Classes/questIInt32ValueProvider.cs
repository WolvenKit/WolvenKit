
namespace WolvenKit.RED4.Types
{
	public abstract partial class questIInt32ValueProvider : ISerializable
	{
		public questIInt32ValueProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
