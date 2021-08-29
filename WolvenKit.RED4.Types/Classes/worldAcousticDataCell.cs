using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldAcousticDataCell : RedBaseClass
	{
		private SerializationDeferredDataBuffer _nodes;
		private CUInt32 _sectorId;

		[Ordinal(0)] 
		[RED("nodes")] 
		public SerializationDeferredDataBuffer Nodes
		{
			get => GetProperty(ref _nodes);
			set => SetProperty(ref _nodes, value);
		}

		[Ordinal(1)] 
		[RED("sectorId")] 
		public CUInt32 SectorId
		{
			get => GetProperty(ref _sectorId);
			set => SetProperty(ref _sectorId, value);
		}
	}
}
