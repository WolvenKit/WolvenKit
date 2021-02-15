using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldSpawnPointMarker : worldIMarker
	{
		[Ordinal(0)] [RED("type")] public CUInt32 Type { get; set; }

		public worldSpawnPointMarker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
