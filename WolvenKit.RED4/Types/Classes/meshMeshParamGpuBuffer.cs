using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshMeshParamGpuBuffer : meshMeshParameter
	{
		[Ordinal(0)] 
		[RED("stride")] 
		public CUInt32 Stride
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public DataBuffer Data
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		public meshMeshParamGpuBuffer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
