using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiInGameMenuGameControllerGarmentSwitchEffectController : CVariable
	{
		[Ordinal(0)]  [RED("effectName")] public CName EffectName { get; set; }
		[Ordinal(1)]  [RED("sceneName")] public CName SceneName { get; set; }

		public gameuiInGameMenuGameControllerGarmentSwitchEffectController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
