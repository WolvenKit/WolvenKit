using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SingleCooldownManager : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("sprite")] public inkImageWidgetReference Sprite { get; set; }
		[Ordinal(2)] [RED("spriteBg")] public inkImageWidgetReference SpriteBg { get; set; }
		[Ordinal(3)] [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(4)] [RED("type")] public CEnum<ECooldownGameControllerMode> Type { get; set; }
		[Ordinal(5)] [RED("name")] public inkTextWidgetReference Name { get; set; }
		[Ordinal(6)] [RED("desc")] public inkTextWidgetReference Desc { get; set; }
		[Ordinal(7)] [RED("timeRemaining")] public inkTextWidgetReference TimeRemaining { get; set; }
		[Ordinal(8)] [RED("stackCount")] public inkTextWidgetReference StackCount { get; set; }
		[Ordinal(9)] [RED("fill")] public inkRectangleWidgetReference Fill { get; set; }
		[Ordinal(10)] [RED("outroDuration")] public CFloat OutroDuration { get; set; }
		[Ordinal(11)] [RED("fullSizeValue")] public Vector2 FullSizeValue { get; set; }
		[Ordinal(12)] [RED("initialDuration")] public CFloat InitialDuration { get; set; }
		[Ordinal(13)] [RED("state")] public CEnum<ECooldownIndicatorState> State { get; set; }
		[Ordinal(14)] [RED("pool")] public inkCompoundWidgetReference Pool { get; set; }
		[Ordinal(15)] [RED("grid")] public inkCompoundWidgetReference Grid { get; set; }
		[Ordinal(16)] [RED("currentAnimProxy")] public CHandle<inkanimProxy> CurrentAnimProxy { get; set; }
		[Ordinal(17)] [RED("buffData")] public UIBuffInfo BuffData { get; set; }
		[Ordinal(18)] [RED("defaultTimeRemainingText")] public CString DefaultTimeRemainingText { get; set; }
		[Ordinal(19)] [RED("excludedStatusEffect")] public TweakDBID ExcludedStatusEffect { get; set; }
		[Ordinal(20)] [RED("C_EXCLUDED_STATUS_EFFECT_NAME")] public CString C_EXCLUDED_STATUS_EFFECT_NAME { get; set; }

		public SingleCooldownManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
