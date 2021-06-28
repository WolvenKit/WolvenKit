using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiBaseMenuGameController : gameuiWidgetGameController
	{
		private CArray<gameuiBaseMenuGameControllerPuppetSceneInfo> _puppetSceneInfos;

		[Ordinal(2)] 
		[RED("puppetSceneInfos")] 
		public CArray<gameuiBaseMenuGameControllerPuppetSceneInfo> PuppetSceneInfos
		{
			get => GetProperty(ref _puppetSceneInfos);
			set => SetProperty(ref _puppetSceneInfos, value);
		}

		public gameuiBaseMenuGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
