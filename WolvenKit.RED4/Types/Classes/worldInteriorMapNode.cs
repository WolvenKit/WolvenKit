using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldInteriorMapNode : worldNode
	{
		[Ordinal(4)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(5)] 
		[RED("coords")] 
		public CUInt64 Coords
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(6)] 
		[RED("buffer")] 
		public SerializationDeferredDataBuffer Buffer
		{
			get => GetPropertyValue<SerializationDeferredDataBuffer>();
			set => SetPropertyValue<SerializationDeferredDataBuffer>(value);
		}

		public worldInteriorMapNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
