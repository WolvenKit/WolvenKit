using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_ExitCover : animAnimFeature_AIAction
	{
		[Ordinal(1)]  [RED("coverStance")] public CInt32 CoverStance { get; set; }
		[Ordinal(2)]  [RED("coverExitDirection")] public CInt32 CoverExitDirection { get; set; }

		public animAnimFeature_ExitCover(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
