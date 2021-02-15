using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animLookAtPreset_Eyes : animLookAtPreset
	{
		[Ordinal(0)] [RED("softLimitAngle")] public CFloat SoftLimitAngle { get; set; }

		public animLookAtPreset_Eyes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
