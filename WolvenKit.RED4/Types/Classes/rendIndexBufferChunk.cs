using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendIndexBufferChunk : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("pe")] 
		public CEnum<GpuWrapApieIndexBufferChunkType> Pe
		{
			get => GetPropertyValue<CEnum<GpuWrapApieIndexBufferChunkType>>();
			set => SetPropertyValue<CEnum<GpuWrapApieIndexBufferChunkType>>(value);
		}

		[Ordinal(1)] 
		[RED("teOffset")] 
		public CUInt32 TeOffset
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public rendIndexBufferChunk()
		{
			Pe = Enums.GpuWrapApieIndexBufferChunkType.IBCT_Max;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
