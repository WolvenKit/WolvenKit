using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questTeleportPuppetParams : CVariable
	{
		[Ordinal(0)]  [RED("destinationRef")] public CHandle<questUniversalRef> DestinationRef { get; set; }
		[Ordinal(1)]  [RED("destinationOffset")] public Vector3 DestinationOffset { get; set; }

		public questTeleportPuppetParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
