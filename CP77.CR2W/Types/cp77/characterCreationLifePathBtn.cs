using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class characterCreationLifePathBtn : inkButtonController
	{
		[Ordinal(10)] [RED("selector")] public inkWidgetReference Selector { get; set; }
		[Ordinal(11)] [RED("desc")] public inkTextWidgetReference Desc { get; set; }
		[Ordinal(12)] [RED("image")] public inkImageWidgetReference Image { get; set; }
		[Ordinal(13)] [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(14)] [RED("video")] public inkVideoWidgetReference Video { get; set; }
		[Ordinal(15)] [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(16)] [RED("root")] public CHandle<inkWidget> Root { get; set; }
		[Ordinal(17)] [RED("translationAnimationCtrl")] public CHandle<inkTextReplaceAnimationController> TranslationAnimationCtrl { get; set; }
		[Ordinal(18)] [RED("localizedText")] public CString LocalizedText { get; set; }

		public characterCreationLifePathBtn(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
