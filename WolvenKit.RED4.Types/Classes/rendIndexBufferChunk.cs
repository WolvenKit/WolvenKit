using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendIndexBufferChunk : RedBaseClass
	{
		private CEnum<GpuWrapApieIndexBufferChunkType> _pe;
		private CUInt32 _teOffset;

		[Ordinal(0)] 
		[RED("pe")] 
		public CEnum<GpuWrapApieIndexBufferChunkType> Pe
		{
			get => GetProperty(ref _pe);
			set => SetProperty(ref _pe, value);
		}

		[Ordinal(1)] 
		[RED("teOffset")] 
		public CUInt32 TeOffset
		{
			get => GetProperty(ref _teOffset);
			set => SetProperty(ref _teOffset, value);
		}

		public rendIndexBufferChunk()
		{
			_pe = new() { Value = Enums.GpuWrapApieIndexBufferChunkType.IBCT_Max };
		}
	}
}
