using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayerDevelopmentDataManager : IScriptable
	{
		[Ordinal(0)]  [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(1)]  [RED("playerDevSystem")] public CHandle<PlayerDevelopmentSystem> PlayerDevSystem { get; set; }
		[Ordinal(2)]  [RED("parentGameCtrl")] public wCHandle<gameuiWidgetGameController> ParentGameCtrl { get; set; }

		public PlayerDevelopmentDataManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
