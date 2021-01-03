using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldAcousticDataCell : CVariable
	{
		[Ordinal(0)]  [RED("nodes")] public serializationDeferredDataBuffer Nodes { get; set; }
		[Ordinal(1)]  [RED("sectorId")] public CUInt32 SectorId { get; set; }

		public worldAcousticDataCell(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
