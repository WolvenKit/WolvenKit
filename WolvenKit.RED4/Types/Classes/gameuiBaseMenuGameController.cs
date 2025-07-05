using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiBaseMenuGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("puppetSceneInfos")] 
		public CArray<gameuiBaseMenuGameControllerPuppetSceneInfo> PuppetSceneInfos
		{
			get => GetPropertyValue<CArray<gameuiBaseMenuGameControllerPuppetSceneInfo>>();
			set => SetPropertyValue<CArray<gameuiBaseMenuGameControllerPuppetSceneInfo>>(value);
		}

		public gameuiBaseMenuGameController()
		{
			PuppetSceneInfos = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
