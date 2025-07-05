
namespace WolvenKit.RED4.Types
{
	public abstract partial class resStreamedResource : CResource
	{
		public resStreamedResource()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
