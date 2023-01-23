
namespace WolvenKit.RED4.Types
{
	public partial class CommunityProxyPS : MasterControllerPS
	{
		public CommunityProxyPS()
		{
			RevealDevicesGrid = false;
			HasNetworkBackdoor = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
