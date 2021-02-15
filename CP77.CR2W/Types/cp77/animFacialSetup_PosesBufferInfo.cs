using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animFacialSetup_PosesBufferInfo : CVariable
	{
		[Ordinal(0)] [RED("face")] public animFacialSetup_OneSermoPoseBufferInfo Face { get; set; }
		[Ordinal(1)] [RED("tongue")] public animFacialSetup_OneSermoPoseBufferInfo Tongue { get; set; }
		[Ordinal(2)] [RED("eyes")] public animFacialSetup_OneSermoPoseBufferInfo Eyes { get; set; }

		public animFacialSetup_PosesBufferInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
