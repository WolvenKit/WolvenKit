using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldAcousticDataCell : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("nodes")] 
		public SerializationDeferredDataBuffer Nodes
		{
			get => GetPropertyValue<SerializationDeferredDataBuffer>();
			set => SetPropertyValue<SerializationDeferredDataBuffer>(value);
		}

		[Ordinal(1)] 
		[RED("sectorId")] 
		public CUInt32 SectorId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public worldAcousticDataCell()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
