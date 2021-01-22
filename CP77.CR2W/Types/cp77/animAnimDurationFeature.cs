using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimDurationFeature : animAnimFeature
	{
		[Ordinal(0)]  [RED("duration")] public CFloat Duration { get; set; }

		public animAnimDurationFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
