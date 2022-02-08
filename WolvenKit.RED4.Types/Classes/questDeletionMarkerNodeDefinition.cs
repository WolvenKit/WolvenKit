using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questDeletionMarkerNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] 
		[RED("deletedNodeIds")] 
		public CArray<CUInt16> DeletedNodeIds
		{
			get => GetPropertyValue<CArray<CUInt16>>();
			set => SetPropertyValue<CArray<CUInt16>>(value);
		}

		public questDeletionMarkerNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
			DeletedNodeIds = new();
		}
	}
}
