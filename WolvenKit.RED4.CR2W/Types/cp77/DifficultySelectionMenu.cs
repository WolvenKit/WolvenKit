using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DifficultySelectionMenu : gameuiBaseCharacterCreationController
	{
		[Ordinal(6)] [RED("difficultyTitle")] public inkTextWidgetReference DifficultyTitle { get; set; }
		[Ordinal(7)] [RED("difficultyIcon")] public inkImageWidgetReference DifficultyIcon { get; set; }
		[Ordinal(8)] [RED("difficulty0")] public inkWidgetReference Difficulty0 { get; set; }
		[Ordinal(9)] [RED("difficulty1")] public inkWidgetReference Difficulty1 { get; set; }
		[Ordinal(10)] [RED("difficulty2")] public inkWidgetReference Difficulty2 { get; set; }
		[Ordinal(11)] [RED("difficulty3")] public inkWidgetReference Difficulty3 { get; set; }
		[Ordinal(12)] [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(13)] [RED("c_atlas1")] public redResourceReferenceScriptToken C_atlas1 { get; set; }
		[Ordinal(14)] [RED("c_atlas2")] public redResourceReferenceScriptToken C_atlas2 { get; set; }
		[Ordinal(15)] [RED("translationAnimationCtrl")] public CHandle<inkTextReplaceAnimationController> TranslationAnimationCtrl { get; set; }
		[Ordinal(16)] [RED("localizedText")] public CString LocalizedText { get; set; }

		public DifficultySelectionMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
