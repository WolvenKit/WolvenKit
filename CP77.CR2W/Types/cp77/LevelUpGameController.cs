using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
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
