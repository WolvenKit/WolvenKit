using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiBaseMenuGameController : gameuiWidgetGameController
	{
		private CArray<gameuiBaseMenuGameControllerPuppetSceneInfo> _puppetSceneInfos;

		[Ordinal(2)] 
		[RED("puppetSceneInfos")] 
		public CArray<gameuiBaseMenuGameControllerPuppetSceneInfo> PuppetSceneInfos
		{
			get => GetProperty(ref _puppetSceneInfos);
			set => SetProperty(ref _puppetSceneInfos, value);
		}
	}
}
