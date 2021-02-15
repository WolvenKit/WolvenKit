using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldTrafficPersistentLaneSpots : CVariable
	{
		[Ordinal(0)] [RED("spots")] public CArray<CHandle<worldTrafficSpotCompiled>> Spots { get; set; }

		public worldTrafficPersistentLaneSpots(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
