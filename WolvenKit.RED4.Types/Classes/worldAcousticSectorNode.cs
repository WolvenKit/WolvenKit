using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldAcousticSectorNode : worldNode
	{
		[Ordinal(4)] 
		[RED("data")] 
		public CResourceAsyncReference<worldAcousticDataResource> Data
		{
			get => GetPropertyValue<CResourceAsyncReference<worldAcousticDataResource>>();
			set => SetPropertyValue<CResourceAsyncReference<worldAcousticDataResource>>(value);
		}

		[Ordinal(5)] 
		[RED("inSectorCoordsX")] 
		public CUInt32 InSectorCoordsX
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(6)] 
		[RED("inSectorCoordsY")] 
		public CUInt32 InSectorCoordsY
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(7)] 
		[RED("inSectorCoordsZ")] 
		public CUInt32 InSectorCoordsZ
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(8)] 
		[RED("generatorId")] 
		public CUInt32 GeneratorId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(9)] 
		[RED("edgeMask")] 
		public CUInt8 EdgeMask
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public worldAcousticSectorNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
