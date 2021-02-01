using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameMovingPlatformArrivedAt : redEvent
	{
		[Ordinal(0)]  [RED("data")] public CInt32 Data { get; set; }
		[Ordinal(1)]  [RED("destinationName")] public CName DestinationName { get; set; }

		public gameMovingPlatformArrivedAt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
