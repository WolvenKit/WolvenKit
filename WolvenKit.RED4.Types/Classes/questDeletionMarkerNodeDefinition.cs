using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questDeletionMarkerNodeDefinition : questSignalStoppingNodeDefinition
	{
		private CArray<CUInt16> _deletedNodeIds;

		[Ordinal(2)] 
		[RED("deletedNodeIds")] 
		public CArray<CUInt16> DeletedNodeIds
		{
			get => GetProperty(ref _deletedNodeIds);
			set => SetProperty(ref _deletedNodeIds, value);
		}
	}
}
