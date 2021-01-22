using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AccumulatedDamageDigitLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("active")] public CBool Active { get; set; }
		[Ordinal(1)]  [RED("animBothOffsetX")] public CFloat AnimBothOffsetX { get; set; }
		[Ordinal(2)]  [RED("animBothOffsetY")] public CFloat AnimBothOffsetY { get; set; }
		[Ordinal(3)]  [RED("animBothStickingOffsetY")] public CFloat AnimBothStickingOffsetY { get; set; }
		[Ordinal(4)]  [RED("animBothTimeCritDelay")] public CFloat AnimBothTimeCritDelay { get; set; }
		[Ordinal(5)]  [RED("animBothTimeCritFade")] public CFloat AnimBothTimeCritFade { get; set; }
		[Ordinal(6)]  [RED("animBothTimeDelay")] public CFloat AnimBothTimeDelay { get; set; }
		[Ordinal(7)]  [RED("animBothTimeFadeIn")] public CFloat AnimBothTimeFadeIn { get; set; }
		[Ordinal(8)]  [RED("animBothTimeFadeOut")] public CFloat AnimBothTimeFadeOut { get; set; }
		[Ordinal(9)]  [RED("animDistanceHeightBias")] public CFloat AnimDistanceHeightBias { get; set; }
		[Ordinal(10)]  [RED("animDistanceModifierMaxDistance")] public CFloat AnimDistanceModifierMaxDistance { get; set; }
		[Ordinal(11)]  [RED("animDistanceModifierMaxValue")] public CFloat AnimDistanceModifierMaxValue { get; set; }
		[Ordinal(12)]  [RED("animDistanceModifierMinDistance")] public CFloat AnimDistanceModifierMinDistance { get; set; }
		[Ordinal(13)]  [RED("animDistanceModifierMinValue")] public CFloat AnimDistanceModifierMinValue { get; set; }
		[Ordinal(14)]  [RED("animDynamicFadeInDuration")] public CFloat AnimDynamicFadeInDuration { get; set; }
		[Ordinal(15)]  [RED("animEndHeight")] public CFloat AnimEndHeight { get; set; }
		[Ordinal(16)]  [RED("animMaxScreenDistanceFromLast")] public CFloat AnimMaxScreenDistanceFromLast { get; set; }
		[Ordinal(17)]  [RED("animMinScreenDistanceFromLast")] public CFloat AnimMinScreenDistanceFromLast { get; set; }
		[Ordinal(18)]  [RED("animNegativeOpacity")] public CFloat AnimNegativeOpacity { get; set; }
		[Ordinal(19)]  [RED("animPopEndScale")] public CFloat AnimPopEndScale { get; set; }
		[Ordinal(20)]  [RED("animPopInDuration")] public CFloat AnimPopInDuration { get; set; }
		[Ordinal(21)]  [RED("animPopOutDuration")] public CFloat AnimPopOutDuration { get; set; }
		[Ordinal(22)]  [RED("animPopScale")] public CFloat AnimPopScale { get; set; }
		[Ordinal(23)]  [RED("animPositiveOpacity")] public CFloat AnimPositiveOpacity { get; set; }
		[Ordinal(24)]  [RED("animScreenInterpolationTime")] public CFloat AnimScreenInterpolationTime { get; set; }
		[Ordinal(25)]  [RED("animStartHeight")] public CFloat AnimStartHeight { get; set; }
		[Ordinal(26)]  [RED("animStickTargetOffset")] public Vector4 AnimStickTargetOffset { get; set; }
		[Ordinal(27)]  [RED("animStickTargetWorldZOffset")] public CFloat AnimStickTargetWorldZOffset { get; set; }
		[Ordinal(28)]  [RED("animStickingDistanceHeightBias")] public CFloat AnimStickingDistanceHeightBias { get; set; }
		[Ordinal(29)]  [RED("animStickingOffsetY")] public CFloat AnimStickingOffsetY { get; set; }
		[Ordinal(30)]  [RED("animTimeCritDelay")] public CFloat AnimTimeCritDelay { get; set; }
		[Ordinal(31)]  [RED("animTimeCritFade")] public CFloat AnimTimeCritFade { get; set; }
		[Ordinal(32)]  [RED("animTimeDelay")] public CFloat AnimTimeDelay { get; set; }
		[Ordinal(33)]  [RED("animTimeFadeIn")] public CFloat AnimTimeFadeIn { get; set; }
		[Ordinal(34)]  [RED("animTimeFadeOut")] public CFloat AnimTimeFadeOut { get; set; }
		[Ordinal(35)]  [RED("arrayPosition")] public CInt32 ArrayPosition { get; set; }
		[Ordinal(36)]  [RED("blinkProxy")] public CHandle<inkanimProxy> BlinkProxy { get; set; }
		[Ordinal(37)]  [RED("calculatedDistanceHeightBias")] public CFloat CalculatedDistanceHeightBias { get; set; }
		[Ordinal(38)]  [RED("critAnimProxy")] public CHandle<inkanimProxy> CritAnimProxy { get; set; }
		[Ordinal(39)]  [RED("critWidget")] public inkTextWidgetReference CritWidget { get; set; }
		[Ordinal(40)]  [RED("currentEngineTime")] public CFloat CurrentEngineTime { get; set; }
		[Ordinal(41)]  [RED("currentlySticking")] public CBool CurrentlySticking { get; set; }
		[Ordinal(42)]  [RED("damageAccumulated")] public CFloat DamageAccumulated { get; set; }
		[Ordinal(43)]  [RED("distanceModifier")] public CFloat DistanceModifier { get; set; }
		[Ordinal(44)]  [RED("gameController")] public wCHandle<DamageDigitsGameController> GameController { get; set; }
		[Ordinal(45)]  [RED("headshotAnimProxy")] public CHandle<inkanimProxy> HeadshotAnimProxy { get; set; }
		[Ordinal(46)]  [RED("headshotWidget")] public inkTextWidgetReference HeadshotWidget { get; set; }
		[Ordinal(47)]  [RED("lastEngineTime")] public CFloat LastEngineTime { get; set; }
		[Ordinal(48)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(49)]  [RED("panelWidget")] public wCHandle<inkWidget> PanelWidget { get; set; }
		[Ordinal(50)]  [RED("positionUpdated")] public CBool PositionUpdated { get; set; }
		[Ordinal(51)]  [RED("projection")] public CHandle<inkScreenProjection> Projection { get; set; }
		[Ordinal(52)]  [RED("projectionFreezePosition")] public CBool ProjectionFreezePosition { get; set; }
		[Ordinal(53)]  [RED("projectionInterpolationOffset")] public inkMargin ProjectionInterpolationOffset { get; set; }
		[Ordinal(54)]  [RED("projectionInterpolationOffsetTotal")] public inkMargin ProjectionInterpolationOffsetTotal { get; set; }
		[Ordinal(55)]  [RED("projectionInterpolationProgress")] public CFloat ProjectionInterpolationProgress { get; set; }
		[Ordinal(56)]  [RED("rootWidget")] public wCHandle<inkWidget> RootWidget { get; set; }
		[Ordinal(57)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(58)]  [RED("showCritAnimDef")] public CHandle<inkanimDefinition> ShowCritAnimDef { get; set; }
		[Ordinal(59)]  [RED("showCritAnimFadeOutInterpolator")] public CHandle<inkanimTransparencyInterpolator> ShowCritAnimFadeOutInterpolator { get; set; }
		[Ordinal(60)]  [RED("showNegativeAnimDef")] public CHandle<inkanimDefinition> ShowNegativeAnimDef { get; set; }
		[Ordinal(61)]  [RED("showNegativeAnimFadeInInterpolator")] public CHandle<inkanimTransparencyInterpolator> ShowNegativeAnimFadeInInterpolator { get; set; }
		[Ordinal(62)]  [RED("showNegativeAnimFadeOutInterpolator")] public CHandle<inkanimTransparencyInterpolator> ShowNegativeAnimFadeOutInterpolator { get; set; }
		[Ordinal(63)]  [RED("showNegativeAnimMarginInterpolator")] public CHandle<inkanimMarginInterpolator> ShowNegativeAnimMarginInterpolator { get; set; }
		[Ordinal(64)]  [RED("showPositiveAnimDef")] public CHandle<inkanimDefinition> ShowPositiveAnimDef { get; set; }
		[Ordinal(65)]  [RED("showPositiveAnimFadeInInterpolator")] public CHandle<inkanimTransparencyInterpolator> ShowPositiveAnimFadeInInterpolator { get; set; }
		[Ordinal(66)]  [RED("showPositiveAnimFadeOutInterpolator")] public CHandle<inkanimTransparencyInterpolator> ShowPositiveAnimFadeOutInterpolator { get; set; }
		[Ordinal(67)]  [RED("showPositiveAnimMarginInterpolator")] public CHandle<inkanimMarginInterpolator> ShowPositiveAnimMarginInterpolator { get; set; }
		[Ordinal(68)]  [RED("showPositiveAnimScaleDownInterpolator")] public CHandle<inkanimScaleInterpolator> ShowPositiveAnimScaleDownInterpolator { get; set; }
		[Ordinal(69)]  [RED("showPositiveAnimScaleUpInterpolator")] public CHandle<inkanimScaleInterpolator> ShowPositiveAnimScaleUpInterpolator { get; set; }
		[Ordinal(70)]  [RED("showingBothDigits")] public CBool ShowingBothDigits { get; set; }
		[Ordinal(71)]  [RED("stickToTarget")] public CBool StickToTarget { get; set; }
		[Ordinal(72)]  [RED("stickingDistanceHeightBias")] public CFloat StickingDistanceHeightBias { get; set; }
		[Ordinal(73)]  [RED("successful")] public CBool Successful { get; set; }
		[Ordinal(74)]  [RED("successfulCritical")] public CBool SuccessfulCritical { get; set; }
		[Ordinal(75)]  [RED("textWidget")] public wCHandle<inkTextWidget> TextWidget { get; set; }

		public AccumulatedDamageDigitLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
