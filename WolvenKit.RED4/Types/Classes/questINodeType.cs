
namespace WolvenKit.RED4.Types
{
	public abstract partial class questINodeType : questIBaseNodeType
	{
		public questINodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
