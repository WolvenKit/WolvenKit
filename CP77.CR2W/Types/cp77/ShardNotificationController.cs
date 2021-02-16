using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ShardNotificationController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("titleRef")] public inkTextWidgetReference TitleRef { get; set; }
		[Ordinal(3)] [RED("shortTextRef")] public inkTextWidgetReference ShortTextRef { get; set; }
		[Ordinal(4)] [RED("longTextRef")] public inkTextWidgetReference LongTextRef { get; set; }
		[Ordinal(5)] [RED("shortTextHolderRef")] public inkWidgetReference ShortTextHolderRef { get; set; }
		[Ordinal(6)] [RED("longTextHolderRef")] public inkWidgetReference LongTextHolderRef { get; set; }
		[Ordinal(7)] [RED("buttonHintsManagerRef")] public inkWidgetReference ButtonHintsManagerRef { get; set; }
		[Ordinal(8)] [RED("buttonHintsManagerParentRef")] public inkWidgetReference ButtonHintsManagerParentRef { get; set; }
		[Ordinal(9)] [RED("buttonHintsSecondaryManagerRef")] public inkWidgetReference ButtonHintsSecondaryManagerRef { get; set; }
		[Ordinal(10)] [RED("buttonHintsSecondaryManagerParentRef")] public inkWidgetReference ButtonHintsSecondaryManagerParentRef { get; set; }
		[Ordinal(11)] [RED("data")] public CHandle<ShardReadPopupData> Data { get; set; }
		[Ordinal(12)] [RED("longTextTrashold")] public CInt32 LongTextTrashold { get; set; }
		[Ordinal(13)] [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(14)] [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(15)] [RED("mingameBB")] public CHandle<gameIBlackboard> MingameBB { get; set; }

		public ShardNotificationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
