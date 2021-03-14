using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProficiencyButtonController : inkButtonController
	{
		[Ordinal(10)] [RED("labelText")] public inkTextWidgetReference LabelText { get; set; }
		[Ordinal(11)] [RED("levelText")] public inkTextWidgetReference LevelText { get; set; }
		[Ordinal(12)] [RED("frameHovered")] public inkWidgetReference FrameHovered { get; set; }
		[Ordinal(13)] [RED("transparencyAnimationProxy")] public CHandle<inkanimProxy> TransparencyAnimationProxy { get; set; }
		[Ordinal(14)] [RED("index")] public CInt32 Index { get; set; }

		public ProficiencyButtonController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
