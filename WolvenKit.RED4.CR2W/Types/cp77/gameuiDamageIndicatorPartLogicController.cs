using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiDamageIndicatorPartLogicController : gameuiBaseDirectionalIndicatorPartLogicController
	{
		[Ordinal(3)] [RED("maxDistanceForSharedIndicators")] public CFloat MaxDistanceForSharedIndicators { get; set; }
		[Ordinal(4)] [RED("arrowFrontWidget")] public inkImageWidgetReference ArrowFrontWidget { get; set; }
		[Ordinal(5)] [RED("damageThreshold")] public CFloat DamageThreshold { get; set; }
		[Ordinal(6)] [RED("root")] public wCHandle<inkWidget> Root { get; set; }
		[Ordinal(7)] [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(8)] [RED("damageTaken")] public CFloat DamageTaken { get; set; }
		[Ordinal(9)] [RED("continuous")] public CBool Continuous { get; set; }

		public gameuiDamageIndicatorPartLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
