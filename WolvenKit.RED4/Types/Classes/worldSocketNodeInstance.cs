
namespace WolvenKit.RED4.Types
{
	public abstract partial class worldSocketNodeInstance : worldINodeInstance
	{
		public worldSocketNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
