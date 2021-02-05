using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class characterCreationSummaryMenu : gameuiBaseCharacterCreationController
	{
		[Ordinal(0)]  [RED("baseEventDispatcher")] public wCHandle<inkMenuEventDispatcher> BaseEventDispatcher { get; set; }
		[Ordinal(1)]  [RED("eventDispatcher")] public wCHandle<inkMenuEventDispatcher> EventDispatcher { get; set; }
		[Ordinal(2)]  [RED("characterCustomizationState")] public CHandle<gameuiICharacterCustomizationState> CharacterCustomizationState { get; set; }
		[Ordinal(3)]  [RED("nextPageHitArea")] public inkWidgetReference NextPageHitArea { get; set; }
		[Ordinal(4)]  [RED("backstoryTitle")] public inkTextWidgetReference BackstoryTitle { get; set; }
		[Ordinal(5)]  [RED("backstoryIcon")] public inkImageWidgetReference BackstoryIcon { get; set; }
		[Ordinal(6)]  [RED("backstory")] public inkTextWidgetReference Backstory { get; set; }
		[Ordinal(7)]  [RED("attributeBodyValue")] public inkTextWidgetReference AttributeBodyValue { get; set; }
		[Ordinal(8)]  [RED("attributeIntelligenceValue")] public inkTextWidgetReference AttributeIntelligenceValue { get; set; }
		[Ordinal(9)]  [RED("attributeReflexesValue")] public inkTextWidgetReference AttributeReflexesValue { get; set; }
		[Ordinal(10)]  [RED("attributeTechnicalAbilityValue")] public inkTextWidgetReference AttributeTechnicalAbilityValue { get; set; }
		[Ordinal(11)]  [RED("attributeCoolValue")] public inkTextWidgetReference AttributeCoolValue { get; set; }
		[Ordinal(12)]  [RED("previousPageBtn")] public inkWidgetReference PreviousPageBtn { get; set; }
		[Ordinal(13)]  [RED("glitchBtn")] public inkWidgetReference GlitchBtn { get; set; }
		[Ordinal(14)]  [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(15)]  [RED("loadingAnimationProxy")] public CHandle<inkanimProxy> LoadingAnimationProxy { get; set; }
		[Ordinal(16)]  [RED("loadingFinished")] public CBool LoadingFinished { get; set; }
		[Ordinal(17)]  [RED("glitchClicks")] public CInt32 GlitchClicks { get; set; }

		public characterCreationSummaryMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
