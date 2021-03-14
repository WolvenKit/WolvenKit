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
			get
			{
				if (_puppetSceneInfos == null)
				{
					_puppetSceneInfos = (CArray<gameuiBaseMenuGameControllerPuppetSceneInfo>) CR2WTypeManager.Create("array:gameuiBaseMenuGameControllerPuppetSceneInfo", "puppetSceneInfos", cr2w, this);
				}
				return _puppetSceneInfos;
			}
			set
			{
				if (_puppetSceneInfos == value)
				{
					return;
				}
				_puppetSceneInfos = value;
				PropertySet(this);
			}
		}

		public gameuiBaseMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
