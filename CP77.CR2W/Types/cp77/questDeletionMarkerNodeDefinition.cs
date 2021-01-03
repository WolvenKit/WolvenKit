using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questDeletionMarkerNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(0)]  [RED("deletedNodeIds")] public CArray<CUInt16> DeletedNodeIds { get; set; }

		public questDeletionMarkerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
