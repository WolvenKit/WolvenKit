using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiDamageIndicatorPartLogicController : gameuiBaseDirectionalIndicatorPartLogicController
	{
		[Ordinal(0)]  [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(1)]  [RED("arrowFrontWidget")] public inkImageWidgetReference ArrowFrontWidget { get; set; }
		[Ordinal(2)]  [RED("continuous")] public CBool Continuous { get; set; }
		[Ordinal(3)]  [RED("damageTaken")] public CFloat DamageTaken { get; set; }
		[Ordinal(4)]  [RED("damageThreshold")] public CFloat DamageThreshold { get; set; }
		[Ordinal(5)]  [RED("maxDistanceForSharedIndicators")] public CFloat MaxDistanceForSharedIndicators { get; set; }
		[Ordinal(6)]  [RED("root")] public wCHandle<inkWidget> Root { get; set; }

		public gameuiDamageIndicatorPartLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
