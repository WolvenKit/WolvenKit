using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_CoverState : animAnimFeature
	{
		[Ordinal(0)]  [RED("debugVar")] public CBool DebugVar { get; set; }
		[Ordinal(1)]  [RED("inCover")] public CBool InCover { get; set; }

		public AnimFeature_CoverState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
