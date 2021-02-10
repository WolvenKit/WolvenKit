using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DifficultySelectionMenu : gameuiBaseCharacterCreationController
	{
		[Ordinal(4)]  [RED("difficultyTitle")] public inkTextWidgetReference DifficultyTitle { get; set; }
		[Ordinal(5)]  [RED("difficultyIcon")] public inkImageWidgetReference DifficultyIcon { get; set; }
		[Ordinal(6)]  [RED("difficulty0")] public inkWidgetReference Difficulty0 { get; set; }
		[Ordinal(7)]  [RED("difficulty1")] public inkWidgetReference Difficulty1 { get; set; }
		[Ordinal(8)]  [RED("difficulty2")] public inkWidgetReference Difficulty2 { get; set; }
		[Ordinal(9)]  [RED("difficulty3")] public inkWidgetReference Difficulty3 { get; set; }
		[Ordinal(10)]  [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(11)]  [RED("c_atlas1")] public redResourceReferenceScriptToken C_atlas1 { get; set; }
		[Ordinal(12)]  [RED("c_atlas2")] public redResourceReferenceScriptToken C_atlas2 { get; set; }
		[Ordinal(13)]  [RED("translationAnimationCtrl")] public CHandle<inkTextReplaceAnimationController> TranslationAnimationCtrl { get; set; }
		[Ordinal(14)]  [RED("localizedText")] public CString LocalizedText { get; set; }

		public DifficultySelectionMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
