using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldAcousticDataCell : CVariable
	{
		[Ordinal(0)] [RED("nodes")] public serializationDeferredDataBuffer Nodes { get; set; }
		[Ordinal(1)] [RED("sectorId")] public CUInt32 SectorId { get; set; }

		public worldAcousticDataCell(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
