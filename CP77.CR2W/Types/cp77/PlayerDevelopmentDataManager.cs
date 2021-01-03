using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PlayerDevelopmentDataManager : IScriptable
	{
		[Ordinal(0)]  [RED("parentGameCtrl")] public wCHandle<gameuiWidgetGameController> ParentGameCtrl { get; set; }
		[Ordinal(1)]  [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(2)]  [RED("playerDevSystem")] public CHandle<PlayerDevelopmentSystem> PlayerDevSystem { get; set; }

		public PlayerDevelopmentDataManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
