using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendVertexBufferChunk : RedBaseClass
	{
		private GpuWrapApiVertexLayoutDesc _vertexLayout;
		private CStatic<CUInt32> _byteOffsets;

		[Ordinal(0)] 
		[RED("vertexLayout")] 
		public GpuWrapApiVertexLayoutDesc VertexLayout
		{
			get => GetProperty(ref _vertexLayout);
			set => SetProperty(ref _vertexLayout, value);
		}

		[Ordinal(1)] 
		[RED("byteOffsets", 5)] 
		public CStatic<CUInt32> ByteOffsets
		{
			get => GetProperty(ref _byteOffsets);
			set => SetProperty(ref _byteOffsets, value);
		}
	}
}
