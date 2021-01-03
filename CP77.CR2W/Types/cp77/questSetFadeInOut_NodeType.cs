using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
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
