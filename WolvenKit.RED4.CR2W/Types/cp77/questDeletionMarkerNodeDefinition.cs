using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questDeletionMarkerNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] [RED("deletedNodeIds")] public CArray<CUInt16> DeletedNodeIds { get; set; }

		public questDeletionMarkerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
