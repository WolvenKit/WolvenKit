using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questDeletionMarkerNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(0)]  [RED("deletedNodeIds")] public CArray<CUInt16> DeletedNodeIds { get; set; }

		public questDeletionMarkerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
