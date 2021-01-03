using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PSD_DetectorPS : gameDeviceComponentPS
	{
		[Ordinal(0)]  [RED("counter")] public CInt32 Counter { get; set; }
		[Ordinal(1)]  [RED("lastEntityID")] public entEntityID LastEntityID { get; set; }
		[Ordinal(2)]  [RED("lastPersistentID")] public gamePersistentID LastPersistentID { get; set; }
		[Ordinal(3)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(4)]  [RED("toggle")] public CBool Toggle { get; set; }

		public PSD_DetectorPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
