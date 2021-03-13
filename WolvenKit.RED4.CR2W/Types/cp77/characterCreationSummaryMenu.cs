using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationSummaryMenu : gameuiBaseCharacterCreationController
	{
		[Ordinal(6)] [RED("backstoryTitle")] public inkTextWidgetReference BackstoryTitle { get; set; }
		[Ordinal(7)] [RED("backstoryIcon")] public inkImageWidgetReference BackstoryIcon { get; set; }
		[Ordinal(8)] [RED("backstory")] public inkTextWidgetReference Backstory { get; set; }
		[Ordinal(9)] [RED("attributeBodyValue")] public inkTextWidgetReference AttributeBodyValue { get; set; }
		[Ordinal(10)] [RED("attributeIntelligenceValue")] public inkTextWidgetReference AttributeIntelligenceValue { get; set; }
		[Ordinal(11)] [RED("attributeReflexesValue")] public inkTextWidgetReference AttributeReflexesValue { get; set; }
		[Ordinal(12)] [RED("attributeTechnicalAbilityValue")] public inkTextWidgetReference AttributeTechnicalAbilityValue { get; set; }
		[Ordinal(13)] [RED("attributeCoolValue")] public inkTextWidgetReference AttributeCoolValue { get; set; }
		[Ordinal(14)] [RED("previousPageBtn")] public inkWidgetReference PreviousPageBtn { get; set; }
		[Ordinal(15)] [RED("glitchBtn")] public inkWidgetReference GlitchBtn { get; set; }
		[Ordinal(16)] [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(17)] [RED("loadingAnimationProxy")] public CHandle<inkanimProxy> LoadingAnimationProxy { get; set; }
		[Ordinal(18)] [RED("loadingFinished")] public CBool LoadingFinished { get; set; }
		[Ordinal(19)] [RED("glitchClicks")] public CInt32 GlitchClicks { get; set; }

		public characterCreationSummaryMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
