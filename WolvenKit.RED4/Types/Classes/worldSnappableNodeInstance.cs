
namespace WolvenKit.RED4.Types
{
	public abstract partial class worldSnappableNodeInstance : worldINodeInstance
	{
		public worldSnappableNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
