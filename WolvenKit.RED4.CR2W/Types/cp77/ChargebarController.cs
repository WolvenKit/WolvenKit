using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChargebarController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("foreground")] public inkWidgetReference Foreground { get; set; }
		[Ordinal(2)] [RED("midground")] public inkWidgetReference Midground { get; set; }
		[Ordinal(3)] [RED("background")] public inkWidgetReference Background { get; set; }
		[Ordinal(4)] [RED("maxChargeAnimationName")] public CName MaxChargeAnimationName { get; set; }
		[Ordinal(5)] [RED("animationMaxCharge")] public CHandle<inkanimProxy> AnimationMaxCharge { get; set; }
		[Ordinal(6)] [RED("statsSystem")] public CHandle<gameStatsSystem> StatsSystem { get; set; }
		[Ordinal(7)] [RED("canFullyCharge")] public CBool CanFullyCharge { get; set; }
		[Ordinal(8)] [RED("canOvercharge")] public CBool CanOvercharge { get; set; }
		[Ordinal(9)] [RED("listenerFullCharge")] public CHandle<ChargebarStatsListener> ListenerFullCharge { get; set; }
		[Ordinal(10)] [RED("listenerOvercharge")] public CHandle<ChargebarStatsListener> ListenerOvercharge { get; set; }

		public ChargebarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
