using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questDeletionMarkerNodeDefinition : questSignalStoppingNodeDefinition
	{
		private CArray<CUInt16> _deletedNodeIds;

		[Ordinal(2)] 
		[RED("deletedNodeIds")] 
		public CArray<CUInt16> DeletedNodeIds
		{
			get => GetProperty(ref _deletedNodeIds);
			set => SetProperty(ref _deletedNodeIds, value);
		}

		public questDeletionMarkerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
