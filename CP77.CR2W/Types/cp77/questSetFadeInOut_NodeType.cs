using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questSetFadeInOut_NodeType : questIRenderFxManagerNodeType
	{
		[Ordinal(0)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(1)]  [RED("fadeColor")] public CColor FadeColor { get; set; }
		[Ordinal(2)]  [RED("fadeIn")] public CBool FadeIn { get; set; }

		public questSetFadeInOut_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
