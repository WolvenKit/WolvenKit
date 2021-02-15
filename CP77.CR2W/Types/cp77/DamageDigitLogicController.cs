using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DamageDigitLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("critWidget")] public inkTextWidgetReference CritWidget { get; set; }
		[Ordinal(2)] [RED("headshotWidget")] public inkTextWidgetReference HeadshotWidget { get; set; }
		[Ordinal(3)] [RED("rootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(4)] [RED("panelWidget")] public wCHandle<inkWidget> PanelWidget { get; set; }
		[Ordinal(5)] [RED("textWidget")] public wCHandle<inkTextWidget> TextWidget { get; set; }
		[Ordinal(6)] [RED("gameController")] public wCHandle<DamageDigitsGameController> GameController { get; set; }
		[Ordinal(7)] [RED("active")] public CBool Active { get; set; }
		[Ordinal(8)] [RED("successful")] public CBool Successful { get; set; }
		[Ordinal(9)] [RED("successfulCritical")] public CBool SuccessfulCritical { get; set; }
		[Ordinal(10)] [RED("showingBothDigits")] public CBool ShowingBothDigits { get; set; }
		[Ordinal(11)] [RED("distanceModifier")] public CFloat DistanceModifier { get; set; }
		[Ordinal(12)] [RED("calculatedDistanceHeightBias")] public CFloat CalculatedDistanceHeightBias { get; set; }
		[Ordinal(13)] [RED("stickingDistanceHeightBias")] public CFloat StickingDistanceHeightBias { get; set; }
		[Ordinal(14)] [RED("stickToTarget")] public CBool StickToTarget { get; set; }
		[Ordinal(15)] [RED("forceStickToTarget")] public CBool ForceStickToTarget { get; set; }
		[Ordinal(16)] [RED("projection")] public CHandle<inkScreenProjection> Projection { get; set; }
		[Ordinal(17)] [RED("showPositiveAnimDef")] public CHandle<inkanimDefinition> ShowPositiveAnimDef { get; set; }
		[Ordinal(18)] [RED("showPositiveAnimFadeInInterpolator")] public CHandle<inkanimTransparencyInterpolator> ShowPositiveAnimFadeInInterpolator { get; set; }
		[Ordinal(19)] [RED("showPositiveAnimFadeOutInterpolator")] public CHandle<inkanimTransparencyInterpolator> ShowPositiveAnimFadeOutInterpolator { get; set; }
		[Ordinal(20)] [RED("showPositiveAnimMarginInterpolator")] public CHandle<inkanimMarginInterpolator> ShowPositiveAnimMarginInterpolator { get; set; }
		[Ordinal(21)] [RED("showPositiveAnimScaleInterpolator")] public CHandle<inkanimScaleInterpolator> ShowPositiveAnimScaleInterpolator { get; set; }
		[Ordinal(22)] [RED("showNegativeAnimDef")] public CHandle<inkanimDefinition> ShowNegativeAnimDef { get; set; }
		[Ordinal(23)] [RED("showNegativeAnimFadeInInterpolator")] public CHandle<inkanimTransparencyInterpolator> ShowNegativeAnimFadeInInterpolator { get; set; }
		[Ordinal(24)] [RED("showNegativeAnimFadeOutInterpolator")] public CHandle<inkanimTransparencyInterpolator> ShowNegativeAnimFadeOutInterpolator { get; set; }
		[Ordinal(25)] [RED("showNegativeAnimMarginInterpolator")] public CHandle<inkanimMarginInterpolator> ShowNegativeAnimMarginInterpolator { get; set; }
		[Ordinal(26)] [RED("showNegativeAnimScaleInterpolator")] public CHandle<inkanimScaleInterpolator> ShowNegativeAnimScaleInterpolator { get; set; }
		[Ordinal(27)] [RED("animStickTargetOffset")] public Vector4 AnimStickTargetOffset { get; set; }
		[Ordinal(28)] [RED("animTimeFadeIn")] public CFloat AnimTimeFadeIn { get; set; }
		[Ordinal(29)] [RED("animTimeFadeOut")] public CFloat AnimTimeFadeOut { get; set; }
		[Ordinal(30)] [RED("animBothTimeFadeIn")] public CFloat AnimBothTimeFadeIn { get; set; }
		[Ordinal(31)] [RED("animBothTimeFadeOut")] public CFloat AnimBothTimeFadeOut { get; set; }
		[Ordinal(32)] [RED("animTimeDelay")] public CFloat AnimTimeDelay { get; set; }
		[Ordinal(33)] [RED("animTimeCritDelay")] public CFloat AnimTimeCritDelay { get; set; }
		[Ordinal(34)] [RED("animBothTimeDelay")] public CFloat AnimBothTimeDelay { get; set; }
		[Ordinal(35)] [RED("animBothTimeCritDelay")] public CFloat AnimBothTimeCritDelay { get; set; }
		[Ordinal(36)] [RED("animStartHeight")] public CFloat AnimStartHeight { get; set; }
		[Ordinal(37)] [RED("animAngleMin1")] public CFloat AnimAngleMin1 { get; set; }
		[Ordinal(38)] [RED("animAngleMin2")] public CFloat AnimAngleMin2 { get; set; }
		[Ordinal(39)] [RED("animAngleMax1")] public CFloat AnimAngleMax1 { get; set; }
		[Ordinal(40)] [RED("animAngleMax2")] public CFloat AnimAngleMax2 { get; set; }
		[Ordinal(41)] [RED("animBothAngleMin1")] public CFloat AnimBothAngleMin1 { get; set; }
		[Ordinal(42)] [RED("animBothAngleMin2")] public CFloat AnimBothAngleMin2 { get; set; }
		[Ordinal(43)] [RED("animBothAngleMax1")] public CFloat AnimBothAngleMax1 { get; set; }
		[Ordinal(44)] [RED("animBothAngleMax2")] public CFloat AnimBothAngleMax2 { get; set; }
		[Ordinal(45)] [RED("animDistanceMin")] public CFloat AnimDistanceMin { get; set; }
		[Ordinal(46)] [RED("animDistanceMax")] public CFloat AnimDistanceMax { get; set; }
		[Ordinal(47)] [RED("animDistanceMin_Crit")] public CFloat AnimDistanceMin_Crit { get; set; }
		[Ordinal(48)] [RED("animDistanceMax_Crit")] public CFloat AnimDistanceMax_Crit { get; set; }
		[Ordinal(49)] [RED("animBothOffsetX")] public CFloat AnimBothOffsetX { get; set; }
		[Ordinal(50)] [RED("animBothOffsetY")] public CFloat AnimBothOffsetY { get; set; }
		[Ordinal(51)] [RED("animBothStickingOffsetY")] public CFloat AnimBothStickingOffsetY { get; set; }
		[Ordinal(52)] [RED("animStickTargetWorldZOffset")] public CFloat AnimStickTargetWorldZOffset { get; set; }
		[Ordinal(53)] [RED("animStickingOffsetY")] public CFloat AnimStickingOffsetY { get; set; }
		[Ordinal(54)] [RED("animDistanceModifierMinDistance")] public CFloat AnimDistanceModifierMinDistance { get; set; }
		[Ordinal(55)] [RED("animDistanceModifierMaxDistance")] public CFloat AnimDistanceModifierMaxDistance { get; set; }
		[Ordinal(56)] [RED("animDistanceModifierMinValue")] public CFloat AnimDistanceModifierMinValue { get; set; }
		[Ordinal(57)] [RED("animDistanceModifierMaxValue")] public CFloat AnimDistanceModifierMaxValue { get; set; }
		[Ordinal(58)] [RED("animDistanceHeightBias")] public CFloat AnimDistanceHeightBias { get; set; }
		[Ordinal(59)] [RED("animStickingDistanceHeightBias")] public CFloat AnimStickingDistanceHeightBias { get; set; }
		[Ordinal(60)] [RED("animPositiveOpacity")] public CFloat AnimPositiveOpacity { get; set; }
		[Ordinal(61)] [RED("animNegativeOpacity")] public CFloat AnimNegativeOpacity { get; set; }
		[Ordinal(62)] [RED("animDynamicDuration")] public CFloat AnimDynamicDuration { get; set; }
		[Ordinal(63)] [RED("animDynamicDelay")] public CFloat AnimDynamicDelay { get; set; }
		[Ordinal(64)] [RED("animDynamicCritDuration")] public CFloat AnimDynamicCritDuration { get; set; }
		[Ordinal(65)] [RED("animDynamicCritDelay")] public CFloat AnimDynamicCritDelay { get; set; }

		public DamageDigitLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
