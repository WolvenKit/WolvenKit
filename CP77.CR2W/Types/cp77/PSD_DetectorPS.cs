using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PSD_DetectorPS : gameDeviceComponentPS
	{
		[Ordinal(12)] [RED("counter")] public CInt32 Counter { get; set; }
		[Ordinal(13)] [RED("toggle")] public CBool Toggle { get; set; }
		[Ordinal(14)] [RED("lastEntityID")] public entEntityID LastEntityID { get; set; }
		[Ordinal(15)] [RED("lastPersistentID")] public gamePersistentID LastPersistentID { get; set; }
		[Ordinal(16)] [RED("name")] public CName Name { get; set; }

		public PSD_DetectorPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
