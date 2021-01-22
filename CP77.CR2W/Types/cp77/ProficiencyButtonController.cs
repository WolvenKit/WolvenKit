using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ProficiencyButtonController : inkButtonController
	{
		[Ordinal(0)]  [RED("frameHovered")] public inkWidgetReference FrameHovered { get; set; }
		[Ordinal(1)]  [RED("index")] public CInt32 Index { get; set; }
		[Ordinal(2)]  [RED("labelText")] public inkTextWidgetReference LabelText { get; set; }
		[Ordinal(3)]  [RED("levelText")] public inkTextWidgetReference LevelText { get; set; }
		[Ordinal(4)]  [RED("transparencyAnimationProxy")] public CHandle<inkanimProxy> TransparencyAnimationProxy { get; set; }

		public ProficiencyButtonController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
