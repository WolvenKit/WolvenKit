
namespace WolvenKit.RED4.Types
{
	public abstract partial class ITexture : CResource
	{
		public ITexture()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
