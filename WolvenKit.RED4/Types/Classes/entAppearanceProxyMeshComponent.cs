
namespace WolvenKit.RED4.Types
{
	public partial class entAppearanceProxyMeshComponent : entPhysicalMeshComponent
	{
		public entAppearanceProxyMeshComponent()
		{
			Name = "";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
