using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animSermoPoseInfo : CVariable
	{
		[Ordinal(0)]  [RED("type")] public CUInt8 Type { get; set; }
		[Ordinal(1)]  [RED("lod")] public CUInt8 Lod { get; set; }
		[Ordinal(2)]  [RED("trackIndex")] public CUInt16 TrackIndex { get; set; }

		public animSermoPoseInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
