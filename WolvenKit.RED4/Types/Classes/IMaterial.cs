
namespace WolvenKit.RED4.Types
{
	public abstract partial class IMaterial : CResource
	{
		public IMaterial()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
