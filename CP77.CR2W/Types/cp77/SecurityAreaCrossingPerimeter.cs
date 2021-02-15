using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SecurityAreaCrossingPerimeter : SecurityAreaEvent
	{
		[Ordinal(27)] [RED("entered")] public CBool Entered { get; set; }

		public SecurityAreaCrossingPerimeter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
