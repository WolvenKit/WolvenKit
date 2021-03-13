using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerBountySystemGameController : BaseChunkGameController
	{
		[Ordinal(5)] [RED("moneyReward")] public inkTextWidgetReference MoneyReward { get; set; }
		[Ordinal(6)] [RED("moneyRewardRow")] public inkWidgetReference MoneyRewardRow { get; set; }
		[Ordinal(7)] [RED("streetCredReward")] public inkTextWidgetReference StreetCredReward { get; set; }
		[Ordinal(8)] [RED("streetCredRewardRow")] public inkWidgetReference StreetCredRewardRow { get; set; }
		[Ordinal(9)] [RED("transgressions")] public inkTextWidgetReference Transgressions { get; set; }
		[Ordinal(10)] [RED("transgressionsWidget")] public inkWidgetReference TransgressionsWidget { get; set; }
		[Ordinal(11)] [RED("rewardPanel")] public inkCompoundWidgetReference RewardPanel { get; set; }
		[Ordinal(12)] [RED("mugShot")] public inkRectangleWidgetReference MugShot { get; set; }
		[Ordinal(13)] [RED("wanted")] public inkTextWidgetReference Wanted { get; set; }
		[Ordinal(14)] [RED("notFound")] public inkTextWidgetReference NotFound { get; set; }
		[Ordinal(15)] [RED("deadNotice")] public inkTextWidgetReference DeadNotice { get; set; }
		[Ordinal(16)] [RED("crossedOut")] public inkWidgetReference CrossedOut { get; set; }
		[Ordinal(17)] [RED("starsWidget")] public CArray<inkWidgetReference> StarsWidget { get; set; }
		[Ordinal(18)] [RED("bountyCallbackID")] public CUInt32 BountyCallbackID { get; set; }
		[Ordinal(19)] [RED("healthCallbackID")] public CUInt32 HealthCallbackID { get; set; }
		[Ordinal(20)] [RED("objectCallbackID")] public CUInt32 ObjectCallbackID { get; set; }
		[Ordinal(21)] [RED("isValidBounty")] public CBool IsValidBounty { get; set; }
		[Ordinal(22)] [RED("isAlive")] public CBool IsAlive { get; set; }
		[Ordinal(23)] [RED("objectType")] public CEnum<ScannerObjectType> ObjectType { get; set; }
		[Ordinal(24)] [RED("showScanBountyAnimProxy")] public CHandle<inkanimProxy> ShowScanBountyAnimProxy { get; set; }

		public ScannerBountySystemGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
