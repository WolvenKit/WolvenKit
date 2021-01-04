using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LevelUpGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(1)]  [RED("data")] public CHandle<LevelUpUserData> Data { get; set; }
		[Ordinal(2)]  [RED("proficencyLabel")] public inkTextWidgetReference ProficencyLabel { get; set; }
		[Ordinal(3)]  [RED("value")] public inkTextWidgetReference Value { get; set; }

		public LevelUpGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
