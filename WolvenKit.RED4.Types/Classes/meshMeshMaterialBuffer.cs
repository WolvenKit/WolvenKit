using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshMeshMaterialBuffer : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("rawData")] 
		public DataBuffer RawData
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(1)] 
		[RED("rawDataHeaders")] 
		public CArray<meshLocalMaterialHeader> RawDataHeaders
		{
			get => GetPropertyValue<CArray<meshLocalMaterialHeader>>();
			set => SetPropertyValue<CArray<meshLocalMaterialHeader>>(value);
		}

		public meshMeshMaterialBuffer()
		{
			RawDataHeaders = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
