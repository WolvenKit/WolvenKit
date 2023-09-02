
namespace WolvenKit.RED4.Types
{
	public abstract partial class questObjectNodeType : questINodeType
	{
		public questObjectNodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
