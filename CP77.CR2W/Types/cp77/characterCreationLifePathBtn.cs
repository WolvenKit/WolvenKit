using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class characterCreationLifePathBtn : inkButtonController
	{
		[Ordinal(0)]  [RED("selector")] public inkWidgetReference Selector { get; set; }
		[Ordinal(1)]  [RED("desc")] public inkTextWidgetReference Desc { get; set; }
		[Ordinal(2)]  [RED("image")] public inkImageWidgetReference Image { get; set; }
		[Ordinal(3)]  [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(4)]  [RED("video")] public inkVideoWidgetReference Video { get; set; }
		[Ordinal(5)]  [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(6)]  [RED("root")] public CHandle<inkWidget> Root { get; set; }
		[Ordinal(7)]  [RED("translationAnimationCtrl")] public CHandle<inkTextReplaceAnimationController> TranslationAnimationCtrl { get; set; }
		[Ordinal(8)]  [RED("localizedText")] public CString LocalizedText { get; set; }

		public characterCreationLifePathBtn(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
