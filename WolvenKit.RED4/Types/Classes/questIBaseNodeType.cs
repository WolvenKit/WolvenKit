
namespace WolvenKit.RED4.Types
{
	public abstract partial class questIBaseNodeType : ISerializable
	{
		public questIBaseNodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
